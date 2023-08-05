using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class webController : Controller
    {
        // GET: web
        public ActionResult Index(int id)
        {
            ViewBag.d = id;
            return View();
        }
    }
}