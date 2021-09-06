using System;
using System.Collections.Generic;
using System.Linq;
using StudyHelperSpa.Models;
namespace StudyHelperSpa.Repositories
{
    public class QuestionsAndAnswersRepository
    {
        public QuestionsAndAnswersRepository()
        {
          
        }

        public List<Question> GetQuestions()
        {
            return GetSeedQuestions().ToList();
        }

        private static IList<Question> GetSeedQuestions()
        {
            List<Question> questions = new()
            {
                new Question
                {
                    Id = 1,
                    Text = "The Cost Management Center can create Budget Alerts? (Yes/No)",
                    CorrectAnswer = "Yes"
                }
            };

            return questions;
        }
    }
}
