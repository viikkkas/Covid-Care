using CovidCare.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidCare.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }
        private readonly ContactDbContext _auc;

        public ContactController(ContactDbContext auc)
        {
            _auc = auc;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Contact(contact uc)
        {
            _auc.Add(uc);
            _auc.SaveChanges();
            ViewBag.message = uc.FirstName + " your message has been recorded.";
            return View();
        }
       
    }
}
