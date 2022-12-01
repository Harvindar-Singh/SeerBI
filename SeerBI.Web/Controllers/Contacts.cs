using Microsoft.AspNetCore.Mvc;

namespace SeerBI.Web.Controllers
{
    public class Contacts : Controller
    {

        // GET: Companies/Create
        public ActionResult Index()
        {
            return View();
        }

        // POST: Companies/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(IFormCollection collection)
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
