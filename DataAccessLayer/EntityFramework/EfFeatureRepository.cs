﻿using DataAccessLayer.Concrete.Context;
using DataAccessLayer.Interface;
using DataAccessLayer.Repositories.GenericRepository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
  public  class EfFeatureRepository : GenericRepository<Feature>, IFeatureDal
    {
        public EfFeatureRepository(Context context)
        {

        }
    }

}
