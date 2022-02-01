using BusinessLayer.Models;
using BusinessLayer.Services.Interface;
using DataAccessLayer.Interface;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services.Concrete
{
    public class AboutService : IAboutService //**generic yapıyı ekle.
    {
        private readonly IAboutDal _aboutDal;

        public AboutService(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void Add(About t)
        {
            throw new NotImplementedException();
        }

        public void Delete(About t)
        {
            throw new NotImplementedException();
        }

        public About GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<AboutViewModel> GetList()
        {
            var list = _aboutDal.GetAll();

            var newlist = list.AsQueryable().Select(x => new AboutViewModel());

            return newlist;
        }

     
        public void Update(About t)
        {
            throw new NotImplementedException();
        }
    }
}
