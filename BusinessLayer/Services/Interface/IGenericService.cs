using BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services.Interface
{
   public interface IGenericService<T>
    {
        void Add(T t);
        void Delete(T t);
        void Update(T t);
        IQueryable<AboutViewModel> GetList();

        T GetById(int id);
    }
}
