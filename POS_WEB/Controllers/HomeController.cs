using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using POS_WEB.Models;

namespace POS_WEB.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(List<Employee> newEmployees)
        {
            string venderNumber = "";
            var singleOrDefault = newEmployees.First();
            if (singleOrDefault != null)
            {
                venderNumber = singleOrDefault.Name;
                TempData["data"] = venderNumber;
            }
            return Json(new { msg = "Successfully added " + venderNumber });
        }


    }
}