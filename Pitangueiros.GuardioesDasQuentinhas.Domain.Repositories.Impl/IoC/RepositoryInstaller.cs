using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Windsor;
using Castle.Windsor.Installer;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Repositories;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Repositories.Impl.IoC
{
    public class RepositoryInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component.For<IPedidoRepository, PedidoMemoryRepository>(),
                Component.For<IClienteRepository, ClienteMemoryRepository>(),
                Component.For<IVendedorRepository, VendedorMemoryRepository>(),
                Component.For<IUsuarioRepository, UsuarioMemoryRepository>(),
                Component.For<ILojaRepository, LojaMemoryRepository>(),
                Component.For<ICartaoRepository, CartaoMemoryRepository>(),
                Component.For<IPratoRepository, PratoMemoryRepository>()
            );
        }
    }
}
