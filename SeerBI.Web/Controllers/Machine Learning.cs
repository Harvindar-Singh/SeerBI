using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SeerBI.Web.Controllers
{
    public class Machine_Learning : Controller
    {
        // GET: Machine_Learning
        public ActionResult Index()
        {
            return View();
        }
        // GET: Computer Vision
        public ActionResult ComputerVision()
        {
            return View();
        }
        // GET: Natural Language Processing
        public ActionResult NLP()
        {
            return View();
        }

        // GET: Machine_Learning/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Machine_Learning/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Machine_Learning/Create
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

        // GET: Machine_Learning/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Machine_Learning/Edit/5
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

        // GET: Machine_Learning/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Machine_Learning/Delete/5
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
