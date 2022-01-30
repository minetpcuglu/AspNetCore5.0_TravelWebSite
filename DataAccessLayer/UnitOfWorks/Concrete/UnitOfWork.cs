using DataAccessLayer.Concrete.Context;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Interface;
using DataAccessLayer.UnitOfWorks.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.UnitOfWorks.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Context _db;

        public UnitOfWork(Context db)
        {
            this._db = db ?? throw new ArgumentNullException("Database Boş Olamaz.");
        }

        private IAboutDal _aboutDal;
        public IAboutDal AboutDal
        {
            get
            {
                if (_aboutDal == null) _aboutDal = new EfAboutRepository(_db);
                return _aboutDal;
            }
        }

        private IAbout2Dal _about2Dal;
        public IAbout2Dal About2Dal
        {
            get
            {
                if (_about2Dal == null) _about2Dal = new EfAbout2Repository(_db);
                return _about2Dal;
            }
        }
        public void Commit() =>  _db.SaveChangesAsync();


        private bool isDisposing = false;
        public async ValueTask DisposeAsync()
        {
            if (!isDisposing)
            {
                isDisposing = true;
                await DisposeAsync(true);
                GC.SuppressFinalize(this); // => Nesnemizi tamamıyla temizlenmesini sağlayacak.
            }
        }
        private async Task DisposeAsync(bool disposing)
        {
            if (disposing) await _db.DisposeAsync(); // => Üretilen db nesnemizi dispose ettik.
        }
    }
}
