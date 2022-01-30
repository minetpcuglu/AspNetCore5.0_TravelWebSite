

using Autofac;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Interface;
using DataAccessLayer.UnitOfWorks.Concrete;
using DataAccessLayer.UnitOfWorks.Interface;

namespace BusinessLayer.IoC
{
    public class RepositoresModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EfAboutRepository>().As<IAboutDal>().InstancePerLifetimeScope();  //**-1- buraya ekleme yapılacak
            builder.RegisterType<EfContactRepository>().As<IContactDal>().InstancePerLifetimeScope();
            builder.RegisterType<EfAbout2Repository>().As<IAbout2Dal>().InstancePerLifetimeScope();
            builder.RegisterType<EfDestinationRepository>().As<IDestinationDal>().InstancePerLifetimeScope();
            builder.RegisterType<EfFeatureRepository>().As<IFeatureDal>().InstancePerLifetimeScope();
            builder.RegisterType<EfFeature2Repository>().As<IFeature2Dal>().InstancePerLifetimeScope();
            builder.RegisterType<EfGuideRepository>().As<IGuideDal>().InstancePerLifetimeScope();
            builder.RegisterType<EfNewsletterRepository>().As<INewsLetterDal>().InstancePerLifetimeScope();
            builder.RegisterType<EfSubAboutRepository>().As<ISubAboutDal>().InstancePerLifetimeScope();
            builder.RegisterType<EfTestimonialRepository>().As<ITestimonialDal>().InstancePerLifetimeScope();

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();
        }
    }
}
