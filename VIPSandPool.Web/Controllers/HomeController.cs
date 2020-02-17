using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VIPSandPool.Data.Services;

namespace VIPSandPool.Web.Controllers
{
    public class HomeController : Controller
    {
        IVirtualServerData db;
        public HomeController(IVirtualServerData db)
        {
            this.db = db;
        }
        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
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