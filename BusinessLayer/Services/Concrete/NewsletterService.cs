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
   public class NewsletterService
    {
        private readonly INewsLetterDal _newsletterDal;

        public NewsletterService(INewsLetterDal newsletterDal)
        {
            _newsletterDal = newsletterDal;
        }

        public void Add(Newsletter t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Newsletter t)
        {
            throw new NotImplementedException();
        }

        public Newsletter GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Newsletter> GetList()
        {
            throw new NotImplementedException();
        }

        public void Update(Newsletter t)
        {
            throw new NotImplementedException();
        }
    }
}
