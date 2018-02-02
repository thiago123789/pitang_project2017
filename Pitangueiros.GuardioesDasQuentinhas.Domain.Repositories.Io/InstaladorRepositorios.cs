using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Repositories.IoC
{
    public class InstaladorRepositorios : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            //container.Register(Component.For<DbContext>).implementby
        }
    }
}