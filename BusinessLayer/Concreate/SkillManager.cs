using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class SkillManager: ISkillService
    {
        ISkillDal _skillDal;

        public SkillManager(ISkillDal skillDal)
        {
            _skillDal = skillDal;
        }

        public void TAdd(Skill t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Skill t)
        {
            throw new NotImplementedException();
        }

        public Skill TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Skill> TGetList()
        {
            return _skillDal.GetList();
        }

        public void TUpdate(Skill t)
        {
            throw new NotImplementedException();
        }
    }
}
