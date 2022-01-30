using DataAccessLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.UnitOfWorks.Interface
{
    public interface IUnitOfWork: IAsyncDisposable
    {
        IAboutDal AboutDal { get; }
        void Commit();
    }
}
