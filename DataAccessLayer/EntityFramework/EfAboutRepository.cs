using BusinessLayer.Models;
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
    public class EfAboutRepository  /*IAboutDal*/
    {
        public EfAboutRepository(Context context)
        {

        }

        public List<AboutViewModel> GetAll()
        {
            //         using var c = new Context();
            //        return c.Set<T>().ToList();
            return null;
            
        }
    }
}
