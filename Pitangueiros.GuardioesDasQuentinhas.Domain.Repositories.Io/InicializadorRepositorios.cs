using Pitangueiros.GuardioesDasQuentinhas.Cross.IoC.Contracts;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Repositories.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Repositories.IoC
{
    public class InicializadorRepositorios : IInicializadorIoC
    {
        public void Inicializar(IGerenciadorIoC gerenciadorIoC)
        {
            gerenciadorIoC.RegistrarAssemblyPorConvencao(Assembly.GetAssembly(typeof(UsuarioRepository)));
        }
    }
}
