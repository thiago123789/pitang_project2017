using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pitangueiros.GuardioesDasQuentinhas.Cross.IoC.Contracts{
    public interface ISolucionadorIoC {

        T Solucionar<T>();

        T Solucionar<T>(Type tipo);

        T Solucionar<T>(Object argumentoComoTipoAnonimo);

        Object Solucionar(Type tipo);

        Object Solucionar(Type tipo, Object argumentoComoTipoAnonimo);

        T[] SolucionarTudo<T>();

        T[] SolucionarTudo<T>(Object argumentoComoTipoAnonimo);

        object[] SolucionarTudo(Type tipo);

        object[] SolucionarTudo(Type tipo, Object argumentoComoTipoAnonimo);

        void Lancamento(Object obj);

        bool EstaRegistrado(Type tipo);

        bool EstaRegistrado<TTipo>();

    }
}
