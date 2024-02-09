using PartialViewsValidationsExceptionHandlingDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartialViewsValidationsExceptionHandlingDemo.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult NewPerson()
        {

            return View();  
        }

        [HttpPost]
        public ActionResult NewPerson(PersonModel person)
        {
            if (ModelState.IsValid)
            {
                return Content("Received data successfully");

            }
            else
            return View();
        }

    }
}