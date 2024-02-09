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

        [NonAction]
        public List<PersonModel> GetList()
        {
            List<PersonModel> persons = new List<PersonModel>() {
            new PersonModel{ Personid=1,FirstName="Anil"},
            new PersonModel{ Personid=2,FirstName="Amit"},
            new PersonModel{ Personid=3,FirstName="Sumit"}

            };
            return persons;
        }


        public ActionResult ShowPersonData()
        {
            // var person = new PersonModel() { Personid=1,FirstName="Amit"};

            List<PersonModel> people=GetList();
            return Json(people, JsonRequestBehavior.DenyGet);
        }



    }
}