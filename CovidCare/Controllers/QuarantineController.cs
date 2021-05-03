using CovidCare.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidCare.Controllers
{
    public class QuarantineController : Controller
    {
        public IActionResult Quarantine()
        {
            return View();
        }
        private readonly QuarantineContext _aux;

        public QuarantineController(QuarantineContext auc)
        {
            _aux = auc;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Quarantine(Quarantine uc)
        {
            _aux.Add(uc);
            _aux.SaveChanges();
            ViewBag.message = uc.Name + " your Request has been Sent.";
            return View();
        }
    }
}
