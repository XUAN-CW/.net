using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        private studentDBContext db = new studentDBContext();
        // GET: Student
        public ActionResult Index()
        {
            return View(db.students.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(T_Student s)
        {
            db.students.Add(s);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(string sno)
        {
            T_Student s = db.students.Find(sno);
            if (s == null)
            {
                return HttpNotFound();
            }
            return View(s);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(T_Student s)
        {
            if (ModelState.IsValid)
            {
                db.Entry(s).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(s);
        }
        public ActionResult Delete(string sno)
        {
            if (sno == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            T_Student s = db.students.Find(sno);
            if (s == null)
            {
                return HttpNotFound();
            }
            return View(s);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult Delete1(string sno)
        {
            T_Student s = db.students.Find(sno);
            db.students.Remove(s);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(string sno)
        {
            if (sno == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            T_Student s = db.students.Find(sno);
            if (s == null)
            {
                return HttpNotFound();
            }
            return View(s);
        }
    }
}