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
   public class TestimonialService : IGenericService<Testimonial> //**generic yapıyı ekle.
    {
        private readonly ITestimonialDal _testimonialDal;

        public TestimonialService(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void Add(Testimonial t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Testimonial t)
        {
            throw new NotImplementedException();
        }

        public Testimonial GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Testimonial> GetList()
        {
            throw new NotImplementedException();
        }

        public void Update(Testimonial t)
        {
            throw new NotImplementedException();
        }
    }
}
