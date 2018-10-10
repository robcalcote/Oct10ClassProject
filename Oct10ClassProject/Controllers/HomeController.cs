using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Oct10ClassProject.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            // This calls the view with the 'Test' name in the ../Views/Home/Test directory
            return View("Test");

            // This would call the view with 'default' name ../Views/Home/Index (same name as method) directory
            //return View();
        }
    }
}