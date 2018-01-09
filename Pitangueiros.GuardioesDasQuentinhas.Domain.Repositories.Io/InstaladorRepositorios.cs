using System.Reflection;
using Pitangueiros.GuardioesDasQuentinhas.Cross.IoC.Contracts;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Repositories.Impl;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Repositories.IoC
{
    public class InstaladorRepositorios: IInicializadorIoC
    {
        public void Inicializar(IGerenciadorIoC gerenciadorIoC)
        {
            gerenciadorIoC.RegistrarAssemblyPorConvencao(Assembly.GetAssembly(typeof(UsuarioMemoryRepository)));
        }
    }
}