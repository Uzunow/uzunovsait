using Microsoft.AspNetCore.Mvc;

namespace LewisHamiltonSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
    }
}

