using Microsoft.AspNetCore.Mvc;

namespace Pierre_Bakery.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }

    }
}