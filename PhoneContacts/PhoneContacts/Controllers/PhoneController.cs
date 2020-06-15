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
    public class PhoneController : Controller
    {
        private PhoneContext context { get; set; }

        public PhoneController(PhoneContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Edit";
            ViewBag.Contacts = context.Contacts.OrderBy(g => g.Name).ToList();
            return View("Edit", new Phone());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var contact = context.Contacts.Find(id);
            return View(contact);
        }

        [HttpPost]
        public IActionResult Edit(Phone phone)
        {
            if (ModelState.IsValid)
            {
                if (phone.PhoneId == 0)
                    context.Contacts.Add(phone);
                else
                    context.Contacts.Update(phone);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (phone.PhoneId == 0) ? "Add" : "Edit";
                ViewBag.Name = context.Contacts.OrderBy(g => g.Name).ToList();
                return View(phone);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var contact = context.Contacts.Find(id);
            return View(contact);
        }

        [HttpPost]
        public IActionResult Delete(Phone phone)
        {
            context.Contacts.Remove(phone);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}

