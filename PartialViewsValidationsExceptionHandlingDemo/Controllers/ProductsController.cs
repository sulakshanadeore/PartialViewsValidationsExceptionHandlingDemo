using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartialViewsValidationsExceptionHandlingDemo.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products

        //[HandleError]


        [HandleError(ExceptionType =typeof(InvalidOperationException),View ="~/Views/Shared/InvalidOperation.cshtml")]
        //[HandleError(ExceptionType = typeof(Exception), View = "Error")]
        //[MyException]
        public ActionResult Index()
        {
            int rate = 0;
            int qty = 0;
            int amt = 0;
            if (rate > 0 && qty > 0)
            {
                 amt = qty * rate;
                ViewBag.invAmt = amt;
            }
            else
            {
                throw new InvalidOperationException();
            }
            return View();  
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            string action = filterContext.RouteData.Values["action"].ToString();
            Exception e=filterContext.Exception;
            filterContext.ExceptionHandled = true;
            filterContext.Result = new ViewResult()
            {
                ViewName = "Error"
            };
            
        }


        //[HandleError()]
        //[HandleError(ExceptionType =typeof(InvalidCastException),View ="Error1")]
        //[HandleError(ExceptionType = typeof(DivideByZeroException),View ="Error")]
        public ViewResult Divide()
        {
            //int i = 1665656756;
            //int j = 1;
            //int k = (checked)i / j;

           
                string y = "10000000";
                //char x = (char)y;
            
            int k = 0;
            ViewBag.ans = k;
            return View();
        }


        //public AcceptResult  

    }
}