using BusinessLayer.Models;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface
{
    public interface IAboutDal
    {
        IQueryable<AboutViewModel> GetAll();
    }
}
