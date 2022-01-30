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
        private IContactDal _contactDal;
        public IContactDal ContactDal
        {
            get
            {
                if (_contactDal == null) _contactDal = new EfContactRepository(_db);
                return _contactDal;
            }
        }
        private IDestinationDal _destinationDal;
        public IDestinationDal DestinationDal //sıkıntı olabilir**
        {
            get
            {
                if (_destinationDal == null) _destinationDal = new EfDestinationRepository(_db);
                return _destinationDal;
            }
        }
        private IFeatureDal _featureDal;
        public IFeatureDal FeatureDal
        {
            get
            {
                if (_featureDal == null) _featureDal = new EfFeatureRepository(_db);
                return _featureDal;
            }
        }

        private IFeature2Dal _feature2Dal;
        public IFeature2Dal Feature2Dal 
        {
            get
            {
                if (_feature2Dal == null) _feature2Dal = new EfFeature2Repository(_db);
                return _feature2Dal;
            }
        }

        private IGuideDal _guideDal;
        public IGuideDal GuideDal
        {
            get
            {
                if (_guideDal == null) _guideDal = new EfGuideRepository(_db);
                return _guideDal;
            }
        }

        private INewsLetterDal _newsLetterDal;
        public INewsLetterDal NewsLetterDal
        {
            get
            {
                if (_newsLetterDal == null) _newsLetterDal = new EfNewsletterRepository(_db);
                return _newsLetterDal;
            }
        }
        private ISubAboutDal _subAboutDal;
        public ISubAboutDal SubAboutDal
        {
            get
            {
                if (_subAboutDal == null) _subAboutDal = new EfSubAboutRepository(_db);
                return _subAboutDal;
            }
        }
        private ITestimonialDal _testimonialDal;
        public ITestimonialDal TestimonialDal
        {
            get
            {
                if (_testimonialDal == null) _testimonialDal = new EfTestimonialRepository(_db);
                return _testimonialDal;
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
