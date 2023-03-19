using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Business.Concrete;
using MyPortfolio.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.WebUI.ViewComponents.Certificate
{
    public class CertificateList :ViewComponent
    {
        CertificateManager _certificateManager = new CertificateManager(new EfCertificateDal());
        public IViewComponentResult Invoke()
        {
            var values = _certificateManager.TGetAll();
            return View(values);
        }
    }
}
