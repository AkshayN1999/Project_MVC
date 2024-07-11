using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PROJECT_MVC.Models;

namespace PROJECT_MVC.Controllers
{
    public class BookInsertController : Controller
    {
        ProjectDBEntities dbobj = new ProjectDBEntities();
        // GET: BookInsert
        public ActionResult Book_Load()
        {
            return View();
        }
        public ActionResult Book_Click(BookDB objcls)
        {
            dbobj.bookinsert(objcls.BookName, objcls.BookSummary);
            objcls.msg = "Inserted Successfully!";
            Session["BName"] = objcls.BookName;
            return View("Book_Load",objcls);
        }
    }
}