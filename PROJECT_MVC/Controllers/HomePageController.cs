using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PROJECT_MVC.Controllers
{
    public class HomePageController : Controller
    {
        // GET: HomePage
        public ActionResult HIndex()
        {
            return View();
        }
    }
}