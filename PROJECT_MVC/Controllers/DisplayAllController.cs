using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PROJECT_MVC.Controllers
{
    public class DisplayAllController : Controller
    {
        ProjectDBEntities dbobj = new ProjectDBEntities();
        // GET: DisplayAll
        public ActionResult Display_Load()
        {
            return View(dbobj.MVC_Tab.ToList());
        }
    }
}