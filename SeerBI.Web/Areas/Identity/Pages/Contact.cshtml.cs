using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SeerBI.Web.Areas.Identity.Pages
{
    public class ContactModel : PageModel
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
