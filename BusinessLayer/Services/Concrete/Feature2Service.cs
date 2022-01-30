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
   public class Feature2Service : IGenericService<Feature2> //**generic yapıyı ekle.
    {
        private readonly IFeature2Dal _feature2Dal;

        public Feature2Service(IFeature2Dal feature2Dal)
        {
            _feature2Dal = feature2Dal;
        }

        public void Add(Feature2 t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Feature2 t)
        {
            throw new NotImplementedException();
        }

        public Feature2 GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Feature2> GetList()
        {
            throw new NotImplementedException();
        }

        public void Update(Feature2 t)
        {
            throw new NotImplementedException();
        }
    }
}
