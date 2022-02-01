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
    public class About2Service : IGenericService<About2> //**generic yapıyı ekle.
    {

        private readonly IAbout2Dal _about2Dal;

        public About2Service(IAbout2Dal about2Dal)
        {
            _about2Dal = about2Dal;
        }

        public void Add(About2 t)
        {
            throw new NotImplementedException();
        }

        public void Delete(About2 t)
        {
            throw new NotImplementedException();
        }

        public About2 GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<AboutViewModel> GetList()
        {
            var list = _about2Dal.GetAll();

            var newlist = list.AsQueryable().Select(x => new AboutViewModel());

            return newlist;
        }

        public void Update(About2 t)
        {
            throw new NotImplementedException();
        }
    }
}
