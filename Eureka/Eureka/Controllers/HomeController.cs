using Eureka.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eureka.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyDatabase database;

        public HomeController(MyDatabase database)
        {
            this.database = database;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}