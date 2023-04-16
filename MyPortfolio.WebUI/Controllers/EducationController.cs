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
    public class EducationController : Controller
    {
        EducationManager _educationManager = new EducationManager(new EfEducationDal());
        public IActionResult Index()
        {
            var values = _educationManager.TGetAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddEducation()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddEducation(Education education)
        {
            _educationManager.TAdd(education);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteEducation(int id)
        {
            var value = _educationManager.TGetByID(id);
            _educationManager.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditEducation(int id)
        {
            var values = _educationManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditEducation(Education education)
        {
            _educationManager.TUpdate(education);

            return RedirectToAction("Index");
        }
        public IActionResult ShowEducation(int id)
        {
            var values = _educationManager.TGetByID(id);
            return View(values);
        }
    }
}
