using System;
using StudyHelperSpa.GraphTypes;
using StudyHelperSpa.Models;
using GraphQL.Types;
using StudyHelperSpa.Services;
namespace StudyHelperSpa.Schema
{
    public class QuestionQuery : ObjectGraphType
    {
        public QuestionQuery(IQuestionsAndAnsweresService questionsAndAnswersService)
        {
            
            Field<ListGraphType<QuestionType>>(name:"questions", resolve: context => {
                return questionsAndAnswersService.GetAllQuestions();
            });
        }
    }
}
