using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ReginaWebsite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class Assignments : Controller
    {
        [Route("[area]/[controller]s/{id?}")]
        public IActionResult List(string id = "All")
        {
            return View();
        }
        // to be built out later for adding 
        public IActionResult Add()
        {
            return View();
        }

        // to be built out later for update
        public IActionResult Update (int id)
        {
            return View(); 
        }

        // to be built out later to delete
        public IActionResult Delete (int id)
        {
            return View();
        }
    }
}
