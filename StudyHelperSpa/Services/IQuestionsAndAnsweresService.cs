using System.Collections.Generic;
using System.Linq;
using StudyHelperSpa.Models;
namespace StudyHelperSpa.Services
{
    public interface IQuestionsAndAnsweresService
    {
        List<Question> GetAllQuestions();
    }
}
