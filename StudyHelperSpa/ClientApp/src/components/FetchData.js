import React, { Component } from 'react';
import authService from './api-authorization/AuthorizeService';
import questionService from './Services/QuestionsService';
export class FetchData extends Component {
  static displayName = FetchData.name;

  constructor(props) {
    super(props);
      this.state = { questions: [], loading: true };
  }

  componentDidMount() {
      this.populateQuestionata();
  }

    static renderQuestionTable(questions) {
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
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
        : FetchData.renderQuestionTable(this.state.questions);

    return (
      <div>
        <h1 id="tabelLabel" >Questions and Answers</h1>
        <p>This component demonstrates fetching data from the server.</p>
        {contents}
      </div>
    );
  }

  async populateQuestionata() {
      const token = await authService.getAccessToken();
      const responseData = await questionService.getQuestionsWithAuth(token);
      
      this.setState({ questions: responseData.data.questions, loading: false });
      console.log('Response data' + this.state.questions);
  }
}
