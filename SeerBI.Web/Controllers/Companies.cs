using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SeerBI.Web.Controllers
{
    public class Companies : Controller
    {
        // GET: Companies
        public ActionResult Index()
        {
            return View();
        }

        // GET: Companies/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Companies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Companies/Create
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

        // GET: Companies/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Companies/Edit/5
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

        // GET: Companies/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Companies/Delete/5
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
