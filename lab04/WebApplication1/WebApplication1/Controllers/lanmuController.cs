using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class lanmuController : Controller
    {
        userDBContext db = new userDBContext();
        // GET: lanmu
        public ActionResult Index()
        {
            return View(db.Categorys);
        }

        // GET: lanmu/Details/5
        public ActionResult Details(int? id) //删除的时候提交的数据只是id 和修改不一样
        {
            Category category = db.Categorys.Find(id); //找到
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category); //放到视图里访问
        }

        // GET: lanmu/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: lanmu/Create
        [HttpPost]
        public ActionResult Create(Category c)
        {
            db.Categorys.Add(c);
            db.SaveChanges();
            return RedirectToAction("Index");   
        }

        // GET: lanmu/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: lanmu/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: lanmu/Delete/5
        public ActionResult Delete(int? id)
        {
            return View();
        }

        // POST: lanmu/Delete/5
        [HttpPost]
        public ActionResult Delete(int? id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
