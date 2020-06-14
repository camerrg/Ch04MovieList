using Microsoft.AspNetCore.Mvc;
using WebApplication1Cameron.Models;

namespace WebApplication1Cameron.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            PersonModel person = new PersonModel();

            return View(person);
        }

        [HttpPost]
        public ActionResult Index(PersonModel person)
        {
            return View(person);
        }

        public ActionResult CalculateByDate()
        {
            PersonExactDateModel person = new PersonExactDateModel();

            return View(person);
        }

        [HttpPost]
        public ActionResult CalculateByDate(PersonExactDateModel personModel)
        {
            return View(personModel);
        }

    }
}