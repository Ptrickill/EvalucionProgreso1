using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EvalucionProgreso1.Models
{
    public class Celular : Controller
    {
        // GET: Celular
        public ActionResult Index()
        {
            return View();
        }

        // GET: Celular/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Celular/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Celular/Create
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

        // GET: Celular/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Celular/Edit/5
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

        // GET: Celular/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Celular/Delete/5
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
