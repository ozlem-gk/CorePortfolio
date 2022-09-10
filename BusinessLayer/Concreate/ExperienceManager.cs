using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class ExperienceManager:IExperinceService
    {
        IExperienceDal _experienceDal;

        public ExperienceManager(IExperienceDal experienceDal)
        {
            _experienceDal = experienceDal;
        }

        public void TAdd(Experience t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Experience t)
        {
            throw new NotImplementedException();
        }

        public Experience TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Experience> TGetList()
        {
            return _experienceDal.GetList();    
        }

        public void TUpdate(Experience t)
        {
            throw new NotImplementedException();
        }
    }
}
