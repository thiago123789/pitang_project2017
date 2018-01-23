using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Pitangueiros.GuardioesDasQuentinhas.Cross.IoC.Contracts;
using Pitangueiros.GuardioesDasQuentinhas.App.Services.Impl;

namespace Pitangueiros.GuardioesDasQuentinhas.App.Services.IoC
{
    public class InicializdorAppService : IInicializadorIoC
    {
        public void Inicializar(IGerenciadorIoC gerenciadorIoC)
        {
            gerenciadorIoC.RegistrarAssemblyPorConvencao(Assembly.GetExecutingAssembly());

        }
    }
}
