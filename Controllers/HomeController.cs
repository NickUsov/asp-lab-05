using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication9.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Controller = RouteData.Values["controller"].ToString();
            ViewBag.Action = RouteData.Values["action"].ToString();
            return View("MainView");
        }

        public ActionResult IndexS()
        {
            ViewBag.Controller = RouteData.Values["controller"].ToString();
            ViewBag.Action = RouteData.Values["action"].ToString();
            return View("MainView");
        }
    }
}