using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AddressBook.Models;

namespace AddressBook.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var contactDetailsTypes = new List<ContactDetailsType>
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
                }
            };
            var model = new List<Person>
            {
                new Person
                {
                    Id = 1,
                    Address = new Address
                    {
                        Id = 1,
                        FirstLine = "12, Quadrant Road",
                        PostCode = "TW9 1DH",
                        City = "London",
                        Country = "England"
                    },
                    ContactDetails = new List<ContactDetails>
                    {
                        new ContactDetails
                        {
                            Id = 1,
                            ContactDetailsType = contactDetailsTypes.First(x => x.Id == 1),
                            Details = "emailaddress@gmail.com"
                        },
                        new ContactDetails
                        {
                            Id = 2,
                            ContactDetailsType = contactDetailsTypes.First(x => x.Id == 2),
                            Details = "0123456789"
                        }
                    },
                    LastName = "Miri",
                    FirstName = "Tarik",
                    DateOfBirth = new DateTime(1988, 9, 16)
                },
                new Person
                {
                    Id = 2,
                    Address = new Address
                    {
                        Id = 1,
                        FirstLine = "12, Quadrant Road",
                        PostCode = "TW9 1DH",
                        City = "London",
                        Country = "England"
                    },
                    ContactDetails = new List<ContactDetails>
                    {
                        new ContactDetails
                        {
                            Id = 1,
                            ContactDetailsType = contactDetailsTypes.First(x => x.Id == 1),
                            Details = "emailaddress@gmail.com"
                        },
                        new ContactDetails
                        {
                            Id = 2,
                            ContactDetailsType = contactDetailsTypes.First(x => x.Id == 2),
                            Details = "0123456789"
                        }
                    },
                    LastName = "Doe",
                    FirstName = "John",
                    DateOfBirth = new DateTime(1970, 9, 24)
                },
            };
            return View(model);
        }
    }
}