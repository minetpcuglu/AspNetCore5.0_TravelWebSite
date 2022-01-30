using DataAccessLayer.Concrete.Context;
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
    public class EfFeature2Repository : GenericRepository<Feature2>, IFeature2Dal
    {
        public EfFeature2Repository(Context context)
        {

        }
    }
}
