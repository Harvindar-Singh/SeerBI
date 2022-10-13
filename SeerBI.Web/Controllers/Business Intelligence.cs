using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SeerBI.Web.Controllers
{
    public class Business_Intelligence : Controller
    {
        // GET: Business_Intelligence
        public ActionResult Index()
        {
            return View();
        }

        // GET: Business_Intelligence/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Business_Intelligence/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Business_Intelligence/Create
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

        // GET: Business_Intelligence/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Business_Intelligence/Edit/5
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

        // GET: Business_Intelligence/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Business_Intelligence/Delete/5
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
