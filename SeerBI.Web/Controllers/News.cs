using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SeerBI.Web.Controllers
{
    public class News : Controller
    {
        // GET: News
        public ActionResult Index()
        {
            return View();
        }
        // GET: News1
        public ActionResult News1()
        {
            return View();
        }
        // GET: News2
        public ActionResult News2()
        {
            return View();
        }
        // GET: News3
        public ActionResult News3()
        {
            return View();
        }
        // GET: News4
        public ActionResult News4()
        {
            return View();
        }
        // GET: News5
        public ActionResult News5()
        {
            return View();
        }
        // GET: News6
        public ActionResult News6()
        {
            return View();
        }
        // GET: News7
        public ActionResult News7()
        {
            return View();
        }
        // GET: News8
        public ActionResult News8()
        {
            return View();
        }
        // GET: News9
        public ActionResult News9()
        {
            return View();
        }
        // GET: News10
        public ActionResult News10()
        {
            return View();

        }

        // GET: News/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: News/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: News/Create
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

        // GET: News/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: News/Edit/5
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

        // GET: News/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: News/Delete/5
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
