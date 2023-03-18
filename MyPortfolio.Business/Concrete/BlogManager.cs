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
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void TAdd(Blog t)
        {
            _blogDal.Add(t);
        }

        public void TDelete(Blog t)
        {
            _blogDal.Delete(t);
        }

        public List<Blog> TGetAll()
        {
            return _blogDal.GetAll();
        }

        public Blog TGetByID(int id)
        {
            return _blogDal.Get(a => a.BlogID.Equals(id));
        }

        public void TUpdate(Blog t)
        {
            _blogDal.Update(t);
        }
    }
}
