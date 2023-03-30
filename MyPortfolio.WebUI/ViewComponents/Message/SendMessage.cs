using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Business.Concrete;
using MyPortfolio.Entities.Concrete;

using MyPortfolio.DataAccess.Concrete.EntityFramework;
using MyPortfolio.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace MyPortfolio.WebUI.ViewComponents.Message
{
    public class SendMessage : ViewComponent
    {
        MessageManager _messageManager = new MessageManager(new EfMessageDal());
        [HttpGet]
        public IViewComponentResult Invoke()
        {
            return View();
        }

        //[HttpPost]
        //public IViewComponentResult Invoke(Entities.Concrete.Message p)
        //{
        //    p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        //    p.Status = true;
        //    _messageManager.TAdd(p);
        //    return View();
        //}
    }
}
