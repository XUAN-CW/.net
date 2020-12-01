using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PRJ037.Models;

namespace PRJ037.Controllers
{
    public class shiptable037Controller : Controller
    {
        private shiptable037Context db = new shiptable037Context();


        public ActionResult calculate()
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            List<shiptable037> result = db.shiptable037.ToList();
            foreach (shiptable037 item in result)
            {
                min = item.load > min ? min : item.load;
                max = item.load > max ? item.load : max;
            }
            
            ViewBag.MESSAGE = "min:"+min+" max:"+max+" 范围:"+min+"~"+max;
            return View();
        }

        // GET: shiptable037
        public ActionResult Index()
        {
            return View(db.shiptable037.ToList());
        }

        // GET: shiptable037/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            shiptable037 shiptable037 = db.shiptable037.Find(id);
            if (shiptable037 == null)
            {
                return HttpNotFound();
            }
            return View(shiptable037);
        }

        // GET: shiptable037/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: shiptable037/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,shipname,load,shiptype,madetime")] shiptable037 shiptable037)
        {
            if (ModelState.IsValid)
            {
                db.shiptable037.Add(shiptable037);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(shiptable037);
        }

        // GET: shiptable037/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            shiptable037 shiptable037 = db.shiptable037.Find(id);
            if (shiptable037 == null)
            {
                return HttpNotFound();
            }
            return View(shiptable037);
        }

        // POST: shiptable037/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,shipname,load,shiptype,madetime")] shiptable037 shiptable037)
        {
            if (ModelState.IsValid)
            {
                db.Entry(shiptable037).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(shiptable037);
        }

        // GET: shiptable037/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            shiptable037 shiptable037 = db.shiptable037.Find(id);
            if (shiptable037 == null)
            {
                return HttpNotFound();
            }
            return View(shiptable037);
        }

        // POST: shiptable037/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            shiptable037 shiptable037 = db.shiptable037.Find(id);
            db.shiptable037.Remove(shiptable037);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
