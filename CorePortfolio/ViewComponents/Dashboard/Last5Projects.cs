using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CorePortfolio.ViewComponents.Dashboard
{
    public class Last5Projects : ViewComponent
    {
       
        public IViewComponentResult Invoke()
        {
           
            return View();
        }
    }
    
}
