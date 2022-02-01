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
    public class GuideService 
    {
        private readonly IGuideDal _guideDal;

        public GuideService(IGuideDal guideDal)
        {
            _guideDal = guideDal;
        }

        public void Add(Guide t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guide t)
        {
            throw new NotImplementedException();
        }

        public Guide GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Guide> GetList()
        {
            throw new NotImplementedException();
        }

        public void Update(Guide t)
        {
            throw new NotImplementedException();
        }
    }
}
