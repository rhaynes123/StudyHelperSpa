using System.Collections.Generic;
using System.Linq;
using StudyHelperSpa.Models;
using StudyHelperSpa.Repositories;
namespace StudyHelperSpa.Services
{
    public class QuestionsAndAnswersService : IQuestionsAndAnsweresService
    {
        private readonly QuestionsAndAnswersRepository _questionsAndAnswersRepository;
        public QuestionsAndAnswersService(QuestionsAndAnswersRepository questionsAndAnswersRepository)
        {
            _questionsAndAnswersRepository = questionsAndAnswersRepository;
        }
        public List<Question> GetAllQuestions()
        {
            return _questionsAndAnswersRepository.GetQuestions();
        }
    }
}
