using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebApplication2.Models;
namespace WebApplication2.Controllers
{
    
        public class UserController : Controller
    {
        userDBContext db = new userDBContext();
        
        
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult changepassword()
        {
            return View();
        }

        [HttpPost]
        public ActionResult changepassword(string Password, string NewPassword, string ConfirmPassword)
        {
            string username = HttpContext.User.Identity.Name;
            var result = db.Users.Where(u => u.UserName == username && u.Password == Password);
            User us = result.FirstOrDefault<User>();
            if (us == null)
            {
                ModelState.AddModelError("Message", "修改失败，无此用户！");
                return View();
            }
            else
            {
                if (ModelState.IsValid)
                {
                    us.UserName = username;
                    us.Password = NewPassword;
                    db.Entry(us).State = EntityState.Modified;
                    DbEntityEntry<User> entry = db.Entry(us);
                    entry.Property("Password").IsModified = true;
                    db.Configuration.ValidateOnSaveEnabled = false;
                    int count = db.SaveChanges();
                    db.Configuration.ValidateOnSaveEnabled = true;
                    return Content("<script language='javascript'type = 'text/javascript' > alert('修改密码成功！');window.location.href = 'index' </ script > ");
                }
                else
                {
                    ModelState.AddModelError("Message", "修改失败！");
                    return View();
                }
            }
        }

        public ActionResult Login()
        {
            FormsAuthentication.SignOut();
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserLogin ug)
        {
            string username = ug.UserName;
            string password = ug.Password; var result = db.Users.Where(u => u.UserName == ug.UserName && u.Password == ug.Password).FirstOrDefault();
            if (result == null)
            {
                ModelState.AddModelError("Message", "登录失败！");
                return View("Login");
            }
            else
            {
                FormsAuthentication.SetAuthCookie(ug.UserName,false);
                return RedirectToAction("changepassword");
            }

        }
        
        public bool find(string username)
        {
            var result = db.Users.Where(p => p.UserName == username).FirstOrDefault();
            if (result == null)
                return false;
            else
                return true;
        }

        public ActionResult Reg()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Reg(reg r)
        {
            if (find(r.UserName) == false)
            {
                User us = r;
                us.Password = r.Password;
                db.Users.Add(us);
                try
                {
                    db.SaveChanges();
                }
                catch (DbEntityValidationException dbEx)
                {
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {

                            ModelState.AddModelError(string.Format("Class: {0}, Property: {1}, Error: {2}", validationErrors.Entry.Entity.GetType().FullName,
                                validationError.PropertyName,
                                validationError.ErrorMessage), "error");
                        }
                    }
                    throw;
                }
                return View();


            }
            else
            {
                return View();
            }
            
        }



    }
}