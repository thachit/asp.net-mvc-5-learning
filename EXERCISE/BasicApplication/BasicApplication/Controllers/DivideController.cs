using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BasicApplication.Controllers
{
    public class DivideController : Controller
    {
        // GET: Divide
        public ActionResult Index()
        {
            return View();
        }

        // POST: Divide
        [HttpPost]
        public ActionResult Index(string firtNumber, string secondNumber)
        {
            int first = Convert.ToInt32(firtNumber);
            int second = Convert.ToInt32(secondNumber);

            if(second > 0)
            {
                ViewBag.Result = first / second;
            }
            else
            {
                ViewBag.Result = "I can not divide";
            }

            return View();
        }
    }
}