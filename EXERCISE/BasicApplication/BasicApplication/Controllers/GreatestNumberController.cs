using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BasicApplication.Controllers
{
    public class GreatestNumberController : Controller
    {
        // GET: GreatestNumber
        public ActionResult Index()
        {
            return View();
        }

        // POST: GreatestNumber
        [HttpPost]
        public ActionResult Index(string FirstNumber, string ThirdNumber, string SecondNumber)
        {
            int first = Int32.Parse(FirstNumber);
            int second = Int32.Parse(SecondNumber);
            int third = Int32.Parse(ThirdNumber);
            int MaxNumber = Math.Max(Math.Max(first, second), third);
            ViewBag.MaxNumber = MaxNumber;

            return View();
        }
    }
}