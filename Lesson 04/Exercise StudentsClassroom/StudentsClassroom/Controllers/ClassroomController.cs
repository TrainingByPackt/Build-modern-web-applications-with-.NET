using StudentsClassroom.Models;
using System;
using System.Web.Mvc;

namespace StudentsClassroom.Controllers
{
    [RoutePrefix("ClassRoom")]
    [Route("{action=Index}")]
    public class ClassRoomController : Controller
    {
        private static readonly ClassRoom _classroom = new ClassRoom();

        public ActionResult Index()
        {
            return View(_classroom.Students);
        }

        [Route("AddStudent")]
        public ActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        [Route("AddStudent")]
        public ActionResult AddStudent(Student student)
        {
            student.Id = _classroom.Students.Count + 1;

            if (ModelState.IsValid)
            {
                _classroom.Students.Add(student);
                return RedirectToAction("Index");
            }

            return View(student);
        }

        private ActionResult RedirectToAction(string v)
        {
            throw new NotImplementedException();
        }
    }
}
