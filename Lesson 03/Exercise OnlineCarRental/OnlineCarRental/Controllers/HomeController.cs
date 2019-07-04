using OnlineCarRental.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace OnlineCarRental.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var model = new List<Car>
                        {
                            new Car{ Make = "Audi", Model = "A5", Year = 2019},
                            new Car{ Make = "Mercedes", Model = "E Class", Year = 2019},
                            new Car{ Make = "VolksWagen", Model = "Golf", Year = 2019},
                    };

            return View(model);
        }
    }

}