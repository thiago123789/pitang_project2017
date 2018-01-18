using Castle.Windsor;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using System.Reflection;
using Castle.Core;
using Pitangueiros.GuardioesDasQuentinhas.App.Contracts;

namespace Pitangueiros.GuardioesDasQuentinhas.App.Services.IoC
{
    public class InstaladorAppService : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Kernel.ComponentRegistered += Kernel_ComponentRegistered;
        }

        private void Kernel_ComponentRegistered(string key, Castle.MicroKernel.IHandler handler)
        {
            if (typeof(IApplicationService).GetTypeInfo()
                .IsAssignableFrom(handler.ComponentModel.Implementation))
            {
                handler.ComponentModel.Interceptors.Add(new InterceptorReference(typeof(IntercptorValidacao)));
            }
        }
    }
}
