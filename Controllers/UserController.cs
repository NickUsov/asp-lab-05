using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication9.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            ViewBag.Controller = RouteData.Values["controller"].ToString();
            ViewBag.Action = RouteData.Values["action"].ToString();
            return View("MainView");
        }

        public ActionResult Settings(int id)
        {
            ViewBag.Controller = RouteData.Values["controller"].ToString();
            ViewBag.Action = RouteData.Values["action"].ToString();
            return View("MainView");
        }
    }
}