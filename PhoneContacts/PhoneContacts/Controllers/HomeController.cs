using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using PhoneContacts.Models;


namespace PhoneContacts.Controllers
{
    public class HomeController : Controller
    {
        private PhoneContext context { get; set; }

        public HomeController(PhoneContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var phone = context.Contacts.OrderBy(m => m.Name).ToList();
            return View(phone);
        }
    }
}
