using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApp.Controllers
{
    public class MyIndexController : Controller
    {
        //
        // GET: /MyIndex/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult doget()
        {
            ViewData["outputdata"] = Request["name"].ToString();
            return View();
        }
    }
}
