using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Business.Concrete;
using MyPortfolio.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.WebUI.ViewComponents.Education
{
    public class EducationList:ViewComponent
    {
        EducationManager _educationManager = new EducationManager(new EfEducationDal());
        public IViewComponentResult Invoke()
        {
            var values = _educationManager.TGetAll();
            return View(values);
        }
    }
}
