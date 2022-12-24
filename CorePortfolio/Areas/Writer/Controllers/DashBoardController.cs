using EntityLayer.Concreate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CorePortfolio.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class DashBoardController : Controller
    {
   
        public IActionResult Index()
        {
            return View();
        }
    }
}
