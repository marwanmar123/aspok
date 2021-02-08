using aspok.Models;
using aspok.Models.Repo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspok.Controllers
{
    public class ClassController : Controller
    {
        private readonly IClassRepo<Class> classRepo;

        public ClassController(IClassRepo<Class> classRepo)
        {
            this.classRepo = classRepo;
        }
        // GET: ClassController
        public ActionResult Index()
        {
            var classe = classRepo.List();
            return View(classe);
        }

        // GET: ClassController/Details/5
        public ActionResult Details(int id)
        {
            var classe = classRepo.Find(id);

            return View(classe);
        }

        // GET: ClassController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClassController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Class classes)
        {
            try
            {
                classRepo.Add(classes);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClassController/Edit/5
        public ActionResult Edit(int id)
        {
            var clss = classRepo.Find(id);
            return View(clss);
        }

        // POST: ClassController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Class classes)
        {
            try
            {
                classRepo.Update(id, classes);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClassController/Delete/5
        public ActionResult Delete(int id)
        {
            var cls = classRepo.Find(id);
            return View(cls);
        }

        // POST: ClassController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Class clss)
        {
            try
            {
                classRepo.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
