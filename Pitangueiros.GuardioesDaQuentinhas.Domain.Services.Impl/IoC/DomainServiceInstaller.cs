using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Services.Impl.IoC
{

    public class DomainServiceInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component.For<IClienteService, ClienteService>(),
                Component.For<ILojaService, LojaService>(),
                Component.For<IPagamentoService, PagamentoService>(),
                Component.For<IUsuarioService, UsuarioService>(),
                Component.For<IVendedorService, VendedorService>()
            );
        }
    }
}
