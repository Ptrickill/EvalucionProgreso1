using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace EvalucionProgreso1.Models
{
    public class Diaz : Controller
    {
        public int Id { get; set; }
        [Required]
        [Range(1,int.MaxValue, ErrorMessage = "El valor debe ser mayor que 0")]
        public string AtrbutoInt { get; set; }

        [Required]
        [Range()]
        // GET: Diaz
        public ActionResult Index()
        {
            return View();
        }

        // GET: Diaz/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Diaz/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Diaz/Create
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

        // GET: Diaz/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Diaz/Edit/5
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

        // GET: Diaz/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Diaz/Delete/5
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
