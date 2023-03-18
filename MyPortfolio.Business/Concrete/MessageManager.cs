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
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public void TAdd(Message t)
        {
            _messageDal.Add(t);
        }

        public void TDelete(Message t)
        {
            _messageDal.Delete(t);
        }

        public List<Message> TGetAll()
        {
            return _messageDal.GetAll();
        }

        public Message TGetByID(int id)
        {
            return _messageDal.Get(a => a.MessageID.Equals(id));
        }

        public void TUpdate(Message t)
        {
            _messageDal.Update(t);
        }
    }
}
