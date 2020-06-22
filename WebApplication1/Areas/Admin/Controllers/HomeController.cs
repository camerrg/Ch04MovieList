using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReginaWebsite.Controllers;

namespace ReginaWebsite.Areas.Admin.Controllers
{

    public class HomeController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View(); // maps to /Areas/View/Home/Index.cshtml
        }
        //attribute routing
        [Route("[action]/{num?}")]
        public IActionResult Countdown(int num = 0)
        {
            string contentString = "counting down:/n";
            for (int i = num; i >= 0; i--)
            {
                contentString += i + "/n";
            }
            return Content(contentString);
        }
        //default route
        public IActionResult Down(int id = 0)
        {
            string contentString = "counting down:/n";
            for (int i = id; i >= 0; i--)
            {
                contentString += i + "/n";
            }
            return Content(contentString);
        }

        //routing rules
        [Route("[action]/{start}/{end?}/{message?}")]
        public IActionResult DownCount (int start, int end =0, string message= "")
        {
            string contentString = "Liftoff!:/end";
            for(int i = start; i >= end; i--)
            {
                contentString += i + "/end";
            }
            return Content(contentString);
        }

    }
}
