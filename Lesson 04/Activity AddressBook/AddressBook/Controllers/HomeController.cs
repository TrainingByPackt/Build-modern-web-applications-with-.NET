using AddressBook.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace AddressBook.Controllers
{
    public class HomeController : Controller
    {
        private static IList<ContactDetailsType> _contactDetailsCTypes = new List<ContactDetailsType>
            {
                new ContactDetailsType
                {
                    Id = 1,
                    Description = "Email"
                },
                new ContactDetailsType
                {
                    Id = 2,
                    Description = "Phone Number"
                },
            };

        private static IList<Person> _persons = new List<Person>
            {
                new Person
                {
                    Id = 1,
                    LastName = "Miri",
                    FirstName = "Tarik",
                    DateOfBirth = new System.DateTime(1988, 9, 16),
                    Address = new Address
                    {
                        Id = 1,
                        FirstLine = "12 Quadrant Road",
                        PostCode = "TW9 1DH",
                        City = "London",
                        Country = "England"
                    },
                    ContactDetails = new List<ContactDetails>
                    {
                        new ContactDetails
                        {
                            Id = 1,
                            ContactDetailsType = _contactDetailsCTypes.First(x => x.Id == 1),
                            Details = "emailaddress@gmail.com"
                        },
                        new ContactDetails
                        {
                            Id = 2,
                            ContactDetailsType = _contactDetailsCTypes.First(x => x.Id == 2),
                            Details = "123456789",
                        }
                    }
                },
                new Person
                {
                    Id = 2,
                    LastName = "Doe",
                    FirstName = "John",
                    DateOfBirth = new System.DateTime(1978, 12, 6),
                    Address = new Address
                    {
                        Id = 2,
                        FirstLine = "12 Street Address",
                        PostCode = "SE1 9LH",
                        City = "London",
                        Country = "England"
                    },
                    ContactDetails = new List<ContactDetails>
                    {
                        new ContactDetails
                        {
                            Id = 1,
                            ContactDetailsType = _contactDetailsCTypes.First(x => x.Id == 1),
                            Details = "johndoe@gmail.com"
                        },
                        new ContactDetails
                        {
                            Id = 2,
                            ContactDetailsType = _contactDetailsCTypes.First(x => x.Id == 2),
                            Details = "83476587326"
                        }
                    }
                }
            };

        // GET: Home
        public ActionResult Index()
        {
            return View(_persons);
        }

        public ActionResult Create()
        {
            var model = new Person();
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(Person model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            model.ContactDetails = new List<ContactDetails>();
            _persons.Add(model);
            return RedirectToAction("Index");
        }

        public ActionResult Detail(int id)
        {
            var person = _persons.FirstOrDefault(x => x.Id == id);
            return View(person);
        }

        public ActionResult Edit(int id)
        {
            var person = _persons.FirstOrDefault(x => x.Id == id);
            return View(person);
        }

        [HttpPost]
        public ActionResult Edit(Person model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var person = _persons.FirstOrDefault(x => x.Id == model.Id);
            person.LastName = model.LastName;
            person.FirstName = model.FirstName;

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var person = _persons.FirstOrDefault(x => x.Id == id);
            return View(person);
        }

        [HttpPost]
        public ActionResult Delete(Person model)
        {
            var person = _persons.FirstOrDefault(x => x.Id == model.Id);
            _persons.Remove(person);
            return RedirectToAction("Index");
        }
    }
}