using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PROJECT_MVC.Models;

namespace PROJECT_MVC.Controllers
{
    public class ChangePasswordController : Controller
    {
        ProjectDBEntities dbobj = new ProjectDBEntities();
        // GET: ChangePassword
        public ActionResult Password_Load()
        {
            return View();
        }
        public ActionResult Password_Click(ChangePwd obj)
        {
            if (ModelState.IsValid)
            {
                ObjectParameter op = new ObjectParameter("status", typeof(int));
                dbobj.sp_pwdchange(Session["UName"].ToString(), obj.OldPassword, obj.NewPassword, op);
                int val = Convert.ToInt32(op.Value);
                if (val != 0)
                {
                    obj.msg = "Changed Password Successfully!";
                    return View("Password_Load", obj);
                }
                else
                {
                    obj.msg = "Password Mismatch!";
                    return View("Password_Load", obj);
                }
            }
            return View("Password_Load", obj);
        }
    }
}