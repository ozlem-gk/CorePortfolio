using Microsoft.AspNetCore.Mvc;

namespace CorePortfolio.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
