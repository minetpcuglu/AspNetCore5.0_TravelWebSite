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
   public class DestinationService : IGenericService<Destination> //**generic yapıyı ekle.
    {
        private readonly IDestinationDal _destinationDal;

        public DestinationService(IDestinationDal destinationDal)
        {
            _destinationDal = destinationDal;
        }

        public void Add(Destination t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Destination t)
        {
            throw new NotImplementedException();
        }

        public Destination GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Destination> GetList()
        {
            throw new NotImplementedException();
        }

        public void Update(Destination t)
        {
            throw new NotImplementedException();
        }
    }
}
