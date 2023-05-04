﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationtemplate.Controllers
{
    public class UserProductController : Controller
    {
        // GET: UserProductController
        public ActionResult Index()
        {
            return View();
        }

        // GET: UserProductController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserProductController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
