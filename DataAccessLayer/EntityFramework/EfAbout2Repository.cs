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
   public class EfAbout2Repository : GenericRepository<About2>, IAbout2Dal
    {
        public EfAbout2Repository(Context context)
        {

        }
    }
}
