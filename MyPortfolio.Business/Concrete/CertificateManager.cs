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
    public class CertificateManager : ICertificateService
    {
        ICertificateDal _certificateDal;

        public CertificateManager(ICertificateDal certificateDal)
        {
            _certificateDal = certificateDal;
        }

        public void TAdd(Certificate t)
        {
            _certificateDal.Add(t);
        }

        public void TDelete(Certificate t)
        {
            _certificateDal.Delete(t);
        }

        public List<Certificate> TGetAll()
        {
            return _certificateDal.GetAll();
        }

        public Certificate TGetByID(int id)
        {
            return _certificateDal.Get(a => a.CertificateID.Equals(id));
        }

        public void TUpdate(Certificate t)
        {
            _certificateDal.Update(t);
        }
    }
}
