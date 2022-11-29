using Microsoft.AspNetCore.Mvc;

namespace DevApp.UI.Site.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
