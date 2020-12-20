using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class StudentController : Controller
    {
        private StudentDBContext db = new StudentDBContext();




        public ActionResult ViewBagTest(int requestData)
        {
            ViewBag.respondData = requestData + 1;
            return View();
        }
        public ActionResult ViewDataTest()
        {
            ViewData["Message"] = "Hello";
            return View();
        }





        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Delete(string id)
        {
            Student student = db.Students.Find(id);
            return View(student);
        }
        public ActionResult Edit(string id)
        {
            Student student = db.Students.Find(id);
            return View(student);
        }
        public ActionResult Details(string id)
        {
            Student student = db.Students.Find(id);
            return View(student);
        }




        [HttpPost]
        public ActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                db.Students.Add(student);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(student);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string id)
        {
            Student student = db.Students.Find(id);
            db.Students.Remove(student);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                db.Entry(student).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
        }
        public ActionResult Index()
        {
            return View(db.Students.ToList());
        }


    }
}
