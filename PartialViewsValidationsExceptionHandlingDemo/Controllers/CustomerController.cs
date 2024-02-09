using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;

namespace PartialViewsValidationsExceptionHandlingDemo.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult ListCustomers()
        {

            //List<string> cList = new List<string>();
            //cList=CountriesList();
            //ViewBag.myCountryList = cList;
            return View();
        }

        [ChildActionOnly]
        public ActionResult RenderMenu()
        {
            return PartialView("_MenuBar");

        }

        [ChildActionOnly]
        public ActionResult CountriesList(List<string> countryData)
        {
            //List<string> list = new List<string>() {
            //"India","US","China","UK","Japan"
            //};
            return View(countryData);
        }

        public ActionResult SupplierList()
        {


            return View();
        }



        //[ChildActionOnly]
        //public ActionResult CountriesList(List<string> countryData)
        //{
        //    //List<string> list = new List<string>() {
        //    //"India","US","China","UK","Japan"
        //    //};
        //return list;

        //}




    }
}
