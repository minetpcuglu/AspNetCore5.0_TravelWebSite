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
  public class SubAboutService : IGenericService<SubAbout> //**generic yapıyı ekle.
    {
        private readonly ISubAboutDal _SubAboutDal;

        public SubAboutService(ISubAboutDal subAboutDal)
        {
            _SubAboutDal =subAboutDal;
        }

        public void Add(SubAbout t)
        {
            throw new NotImplementedException();
        }

        public void Delete(SubAbout t)
        {
            throw new NotImplementedException();
        }

        public SubAbout GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<SubAbout> GetList()
        {
            throw new NotImplementedException();
        }

        public void Update(SubAbout t)
        {
            throw new NotImplementedException();
        }
    }
}
