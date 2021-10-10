import React, { Component } from 'react';
import questionService from './Services/QuestionsService';
export class Home extends Component {
    static displayName = Home.name;

    constructor(props) {
        super(props);
        this.state = { questions: [], loading: true };
    }

    componentDidMount() {
      this.populateQuestiondata();
    }


    static buildQuestionTable(questions) {

        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>#</th>
                        <th>Question</th>
                        <th>Answer</th>
                    </tr>
                </thead>
                <tbody>
                    {questions.map(question =>
                        <tr key={question.id}>
                            <td>{question.id}</td>
                            <td>{question.text}</td>
                            <td>{question.correctAnswer}</td>

                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    render() {
        let pageContents = this.state.loading ? <p><em>Gathering data ... </em></p> : Home.buildQuestionTable(this.state.questions);
        return (
            <div>
                <h1 id="tabelLabel" >Questions and Answers</h1>
                <p>This component demonstrates fetching data from the server.</p>
                {pageContents}
            </div>
        );
    }

    async populateQuestiondata() {
        const responseData = await questionService.getQuestions();
        this.setState({ questions: responseData.data.questions, loading: false });
    }

}



