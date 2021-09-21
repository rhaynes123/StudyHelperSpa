using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudyHelperSpa.Schema;
using StudyHelperSpa.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudyHelperSpa.Controllers.V1
{
    [Authorize]
    //[ApiController]
    //[Route("[controller]")]
    public class QuestionsController : Controller
    {
        private readonly IQuestionsAndAnsweresService _questionsAndAnsweresService;

        public QuestionsController(IQuestionsAndAnsweresService questionsAndAnsweresService)
        {
            _questionsAndAnsweresService = questionsAndAnsweresService;
        }
        // GET: /<controller>/
        //[HttpPost("graphql")]
        public IActionResult Post()
        {
            return Ok(_questionsAndAnsweresService.GetAllQuestions());
        }
    }
}
