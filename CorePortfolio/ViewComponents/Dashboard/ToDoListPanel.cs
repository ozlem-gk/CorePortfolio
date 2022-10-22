using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CorePortfolio.ViewComponents.Dashboard
{
    public class ToDoListPanel : ViewComponent
    {
        ToDoListManager _toDoListManager = new ToDoListManager(new EfToDoListDal());
       public IViewComponentResult Invoke()
        {
            var values = _toDoListManager.TGetList();
            return View(values);
        }
    }
}

