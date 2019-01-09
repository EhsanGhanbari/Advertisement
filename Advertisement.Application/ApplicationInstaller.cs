using Advertisement.Application.Contract;
using Advertisement.Application.Infrastructure;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace Advertisement.Application
{
    public class ApplicationInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<AdvDbDbContext>().LifestyleSingleton());
            container.Register(Component.For<ICampainContract>().ImplementedBy<CampainContract>());
            container.Register(Component.For<IUserContract>().ImplementedBy<UserContract>());
            container.Register(Component.For<IAdvertisementContract>().ImplementedBy<AdvertisementContract>());
            container.Register(Component.For<IChargeContract>().ImplementedBy<ChargeContract>());
        }
    }
}
