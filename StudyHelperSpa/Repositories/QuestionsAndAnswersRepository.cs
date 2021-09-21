using System;
using System.Collections.Generic;
using System.Linq;
using StudyHelperSpa.Models;
using StudyHelperSpa.Data;
namespace StudyHelperSpa.Repositories
{
    public class QuestionsAndAnswersRepository
    {
        private readonly ApplicationDbContext dbContext;
        public QuestionsAndAnswersRepository(ApplicationDbContext context)
        {
            dbContext = context;
        }

        public List<Question> GetQuestions()
        {
            return dbContext.Questions.ToList();
        }
    }
}
