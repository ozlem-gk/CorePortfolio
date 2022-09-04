using BusinessLayer.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace CorePortfolio.ViewComponents.Portfolio
{
    public class PortfolioList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            
            return View();
        }
    }
}
