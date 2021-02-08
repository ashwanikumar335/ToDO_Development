using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcToDoList.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            return View("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "About";

            return View("About");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact";

            return View("Contact");
        }
    }
}