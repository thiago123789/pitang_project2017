using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pitangueiros.GuardioesDasQuentinhas.Cross.IoC.Contracts {
    public interface IConvencaoDependenciaRegistro {
        void RegistrarAssembly(IContextoConvencionalRegistracao contexto);
    }
}
