using Microsoft.AspNetCore.Mvc;

namespace BusinessTrip.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}