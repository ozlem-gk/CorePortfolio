using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CorePortfolio.ViewComponents.Skill
{
    public class SkillList:ViewComponent
    {
        SkillManager _skillmanager = new SkillManager(new EfSkillDal());

        public IViewComponentResult Invoke()
        {
            var values = _skillmanager.TGetList();
            return View(values);
        }
    }
}
