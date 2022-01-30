

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

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();
        }
    }
}
