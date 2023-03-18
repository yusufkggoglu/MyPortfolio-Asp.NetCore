using MyPortfolio.Business.Abstract;
using MyPortfolio.DataAccess.Abstract;
using MyPortfolio.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPortfolio.Business.Concrete
{
    public class EducationManager : IEducationService
    {
        IEducationDal _educationDal;

        public EducationManager(IEducationDal educationDal)
        {
            _educationDal = educationDal;
        }

        public void TAdd(Education t)
        {
            _educationDal.Add(t);
        }

        public void TDelete(Education t)
        {
            _educationDal.Delete(t);
        }

        public List<Education> TGetAll()
        {
            return _educationDal.GetAll();
        }

        public Education TGetByID(int id)
        {
            return _educationDal.Get(a => a.EducationID.Equals(id));
        }

        public void TUpdate(Education t)
        {
            _educationDal.Update(t);
        }
    }
}
