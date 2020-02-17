using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VIPSandPool.Data.Models;
using VIPSandPool.Data.Services;

namespace VIPSandPool.Web.Controllers
{
    public class VirtualServersController : Controller
    {
        private readonly IVirtualServerData db;

        public VirtualServersController(IVirtualServerData db)
        {
            this.db = db;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var model = db.Get(id);
            if (model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VirtualServer virtualserver)
        {
           if (ModelState.IsValid)
            {
                db.Add(virtualserver);
                return RedirectToAction("Details", new { id = virtualserver.Id });
            }

            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = db.Get(id);
            if(model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(VirtualServer virtualserver)
        {
            if(ModelState.IsValid)
            {
                db.Update(virtualserver);
                return RedirectToAction("Details", new { id = virtualserver.Id });
            }
            return View(virtualserver);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var model = db.Get(id);
            if(model == null)
            {
                return View("Not Found");
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection form)
        {
            db.Delete(id);
            return RedirectToAction("Index");
        }
    }
}