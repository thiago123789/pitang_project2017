using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Cross.IoC.Contracts;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Services.Impl;
using System.Reflection;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Services.IoC
{
    public class InicializadorServicosDominio : IInicializadorIoC
    {
        public void Inicializar(IGerenciadorIoC gerenciadorIoC)
        {
            gerenciadorIoC.RegistrarAssemblyPorConvencao(Assembly.GetAssembly(typeof(UsuarioService)));
        }
    }
}
