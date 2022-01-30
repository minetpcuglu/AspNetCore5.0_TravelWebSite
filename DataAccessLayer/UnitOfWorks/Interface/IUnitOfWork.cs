using DataAccessLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.UnitOfWorks.Interface
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IAboutDal AboutDal { get; }
        IAbout2Dal About2Dal { get; }
        IContactDal ContactDal { get; }
        IDestinationDal DestinationDal { get; }
        IFeatureDal FeatureDal { get; }
        IFeature2Dal Feature2Dal { get; }
        IGuideDal GuideDal { get; }
        INewsLetterDal NewsLetterDal { get; }
        ISubAboutDal SubAboutDal { get; }
        ITestimonialDal TestimonialDal { get; }
        void Commit();
    }
}
