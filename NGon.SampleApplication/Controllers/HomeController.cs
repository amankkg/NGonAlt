using System.Web.Mvc;

namespace NGon.SampleApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var person = new Person
                             {
                                 FirstName = "John",
                                 LastName = "Doe",
                                 Age = 30,
                                 Address =
                                     new Address
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

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }
    }

    public class Address
    {
        public string StreetName { get; set; }
        public string County { get; set; }
        public string HouseNumber { get; set; }
        public string HouseName { get; set; }
        public string PostCode { get; set; }
    }
}
