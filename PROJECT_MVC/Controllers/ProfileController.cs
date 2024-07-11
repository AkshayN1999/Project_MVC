using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PROJECT_MVC.Models;

namespace PROJECT_MVC.Controllers
{
    public class ProfileController : Controller
    {
        ProjectDBEntities dbobj = new ProjectDBEntities();
        // GET: Profile
        public ActionResult Profile_Load(ProfileViewAndEdit objcls)
        {
            var getdata = dbobj.sp_pview(Session["UName"].ToString()).FirstOrDefault();
            return View( new ProfileViewAndEdit
            {
                Name = getdata.Name,
                Age = getdata.Age,
                Address = getdata.Address,
                Email = getdata.Email,
                Photo = getdata.Photo
            }
                );
        }
        public ActionResult Profile_Update(ProfileViewAndEdit objcls)
        {
            dbobj.sp_update(Session["UName"].ToString(), objcls.Age, objcls.Address);

            var getdata = dbobj.sp_pview(Session["UName"].ToString()).FirstOrDefault();
            return View("Profile_Load", new ProfileViewAndEdit
            {
                Name = getdata.Name,
                Age = getdata.Age,
                Address = getdata.Address,
                Email = getdata.Email,
                Photo = getdata.Photo
            });

            //objcls.msg = "Updated Successfully!";
        }
    }
}