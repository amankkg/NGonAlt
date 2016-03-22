using NGon.Sample.Models;
using System;
using System.Web.Mvc;

namespace NGon.Sample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var person = new Person
            {
                FirstName = "Dollard",
                LastName = "Grunt",
                BirthDate = new DateTime(1946, 6, 14),
                Address = new Address
                {
                    County = "Kent",
                    HouseName = "Haribo",
                    HouseNumber = "13",
                    PostCode = "Dave",
                    StreetName = "SUplolz"
                }
            };
            ViewBag.NGon.Person = person;
            return View();
        }
    }
}
