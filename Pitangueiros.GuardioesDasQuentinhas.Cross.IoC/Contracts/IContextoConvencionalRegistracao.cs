using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Pitangueiros.GuardioesDasQuentinhas.Cross.IoC.Contracts { 
    public interface IContextoConvencionalRegistracao { 
        Assembly Assembly { get; }

        IGerenciadorIoC GerenciadorIoC { get; }

        ConfiguracaoConvencionalRegistro Config { get; }
    }
}
