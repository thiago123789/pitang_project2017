using System;

namespace Pitangueiros.GuardioesDasQuentinhas.Cross.IoC.Contracts
{
    public interface IDependenciaDescarteObjetoEmpacotado<out T>: IDisposable
    {
        T Objeto { get; }
    }
}