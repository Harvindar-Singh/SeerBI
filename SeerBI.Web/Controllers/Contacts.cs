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
                 public bool hasData = false;
        public string firstname = "";
        public string lastname = "";
        public string message = "";


        public void OnGet()
        {
        }
        public void onPost()
        {


            hasData = true;
            firstname = Request.Form["firstname"];
            lastname = Request.Form["lastname"];
            message = Request.Form["message"];


        }
    }
    }
}
