using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PROJECT_MVC.Models;
using System.IO;

namespace PROJECT_MVC.Controllers
{
    public class InsertController : Controller
    {
        // GET: Insert
        ProjectDBEntities dbobj = new ProjectDBEntities();
        public ActionResult Register_Load()
        {
            return View();
        }
        public ActionResult Register_Click(InsertDB objcls,HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {
                if (file.ContentLength > 0)
                {
                    string fname = Path.GetFileName(file.FileName);
                    var s = Server.MapPath("~/PHS");
                    string pa = Path.Combine(s, fname);
                    file.SaveAs(pa);
                    var fullpath = Path.Combine("~\\PHS", fname);
                    objcls.Photo = fullpath;
                }
                dbobj.sp_insert(objcls.Name, objcls.Age, objcls.Address, objcls.Email, objcls.Photo, objcls.Username, objcls.Password);
                objcls.msg = "Inserted Succesfully!";
                return View("Register_Load", objcls);
            }
            return View("Register_Load", objcls);
        }
    }
}