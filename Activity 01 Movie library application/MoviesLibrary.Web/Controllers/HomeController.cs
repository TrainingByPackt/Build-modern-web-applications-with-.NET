using System.Collections.Generic;
using MoviesLibrary.Web.Models;
using System.Web.Mvc;

namespace MoviesLibrary.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var model = CreateModel();
            return View(model.Movies);
        }

        private MoviesLibrary.Web.Models.MoviesLibrary CreateModel()
        {
            var model = new MoviesLibrary.Web.Models.MoviesLibrary()
            {
                Movies = new List<Movie>()
                {
                    new Movie()
                    {
                        Title = "Pulp Fiction",
                        Synopsis =
                            "The lives of two mob hitmen, a boxer, a gangster & his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                        YearOfProductions = 1994
                    },
                    new Movie()
                    {
                        Title = "Titanic",
                        Synopsis =
                            "A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious, ill-fated R.M.S. Titanic.",
                        YearOfProductions = 1997
                    },
                    new Movie()
                    {
                        Title = "Hitch",
                        Synopsis =
                            "While helping his latest client woo the fine lady of his dreams, a professional date doctor finds that his game doesn't quite work on the gossip columnist with whom he's smitten.",
                        YearOfProductions = 2005
                    },
                    new Movie()
                    {
                        Title = "Home Alone",
                        Synopsis =
                            "An eight-year-old troublemaker must protect his house from a pair of burglars when he is accidentally left home alone by his family during Christmas vacation.",
                        YearOfProductions = 1990
                    }

                }
            };

            return model;
        }
    }
}