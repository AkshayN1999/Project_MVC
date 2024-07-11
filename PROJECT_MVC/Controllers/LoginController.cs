using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PROJECT_MVC.Models;

namespace PROJECT_MVC.Controllers
{
    public class LoginController : Controller
    {
        ProjectDBEntities dbobj = new ProjectDBEntities();
        // GET: Login
        public ActionResult Login_Load()
        {
            return View();
        }
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult Login_Click(LoginDB objcls)
        {
            if (ModelState.IsValid)
            {
                ObjectParameter op = new ObjectParameter("status", typeof(int));
                dbobj.sp_login(objcls.Username, objcls.Password, op);
                int val = Convert.ToInt32(op.Value);
                if(val == 1)
                {
                    Session["UName"] = objcls.Username;
                    return RedirectToAction("Home");
                }
                else
                {
                    ModelState.Clear();
                    objcls.msg = "Invalid Username/Password";
                    return View("Login_Load",objcls);
                }
            }
            return View("Login_Load", objcls);
        }
    }
}