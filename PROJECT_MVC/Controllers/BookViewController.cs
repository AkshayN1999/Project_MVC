using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PROJECT_MVC.Models;

namespace PROJECT_MVC.Controllers
{
    public class BookViewController : Controller
    {
        ProjectDBEntities dbobj = new ProjectDBEntities();
        // GET: BookView
        public ActionResult BookView_Load(BookDB objcls)
        {
            return View(dbobj.BookTabs.ToList());
        }
    }
}