using System;
using System.Collections.Generic;
using StudyHelperSpa.GraphTypes;
using StudyHelperSpa.Models;
//using GraphQL.Types;
using HotChocolate;
using HotChocolate.Types;
using StudyHelperSpa.Services;
namespace StudyHelperSpa.Schema
{
    public class QuestionQuery 
    {
        public List<Question> GetQuestions([Service] IQuestionsAndAnsweresService questionsAndAnsweresService) => questionsAndAnsweresService.GetAllQuestions(); 
        //public QuestionQuery(IQuestionsAndAnsweresService questionsAndAnswersService)
        //{
            
        //    Field<ListGraphType<QuestionType>>(name:"questions", resolve: context => {
        //        return questionsAndAnswersService.GetAllQuestions();
        //    });
        //}
    }
}
