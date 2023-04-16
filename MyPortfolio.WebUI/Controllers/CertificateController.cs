using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Business.Concrete;
using MyPortfolio.DataAccess.Concrete.EntityFramework;
using MyPortfolio.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.WebUI.Controllers
{
    public class CertificateController : Controller
    {
        CertificateManager _certificateManager = new CertificateManager(new EfCertificateDal());
        public IActionResult Index()
        {
            var values = _certificateManager.TGetAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddCertificate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCertificate(Certificate certificate)
        {
            _certificateManager.TAdd(certificate);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteCertificate(int id)
        {
            var value = _certificateManager.TGetByID(id);
            _certificateManager.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditCertificate(int id)
        {
            var values = _certificateManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditCertificate(Certificate certificate)
        {
            _certificateManager.TUpdate(certificate);

            return RedirectToAction("Index");
        }
        public IActionResult ShowCertificate(int id)
        {
            var values = _certificateManager.TGetByID(id);
            return View(values);
        }
    }
}
