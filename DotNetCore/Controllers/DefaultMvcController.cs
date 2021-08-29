using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore.Controllers
{
    public class DefaultMvcController : Controller
    {
        // GET: DefaultMvcController
        public ActionResult Index()
        {
            return View();
        }

        // GET: DefaultMvcController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DefaultMvcController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DefaultMvcController/Create
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

        // GET: DefaultMvcController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DefaultMvcController/Edit/5
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

        // GET: DefaultMvcController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DefaultMvcController/Delete/5
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
