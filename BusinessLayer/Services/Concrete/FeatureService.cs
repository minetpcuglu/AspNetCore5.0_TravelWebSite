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
   public class FeatureService 
    {
        private readonly IFeatureDal _featureDal;

        public FeatureService(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void Add(Feature t)
        {
            throw new NotImplementedException();
        }

     
        public void Delete(Feature t)
        {
            throw new NotImplementedException();
        }

        public void Update(Feature t)
        {
            throw new NotImplementedException();
        }

      

       public List<Feature> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
