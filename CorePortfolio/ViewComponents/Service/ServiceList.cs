using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CorePortfolio.ViewComponents.Service
{
    public class ServiceList: ViewComponent
    {
        ServiceManager servisManager = new ServiceManager(new EfServiceDal());

        public IViewComponentResult Invoke()
        {
            var values = servisManager.TGetList();
            return View(values);
        }
    }
}
