using System.Collections.Generic;
using System.Web.Mvc;
using OnlineQuiz.Models;

namespace OnlineQuiz.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new Quiz
            {
                Players = new List<Player>
                {
                    new Player
                    {
                        Id = 1,
                        Name = "Human Player",
                        PlayerTypes = PlayerTypes.Human
                    },
                    new Player
                    {
                        Id = 2,
                        Name = "AI Player",
                        PlayerTypes = PlayerTypes.AI
                    }
                },
                Questions = new List<Question>
                {
                    new Question
                    {
                        Id = 1,
                        Category = new QuestionCategory
                        {
                            Id = 1,
                            Description = "History"
                        },
                        Description = "Whend did the second world war end?",
                        Answer = "1945"
                    },
                    new Question
                    {
                        Id = 2,
                        Category = new QuestionCategory
                        {
                            Id = 2,
                            Description = "Geography"
                        },
                        Description = "What is the capital of England?",
                        Answer = "London"
                    }
                }
            };
            return View(model);
        }
    }
}