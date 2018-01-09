namespace Pitangueiros.GuardioesDasQuentinhas.Cross.IoC.Contracts
{
    internal class DependenciaDescarteObjetoEmpacotado : DependenciaDescarteObjetoEmpacotado<object>, IDependenciaDescarteObjetoEmpacotado
    {
        public DependenciaDescarteObjetoEmpacotado(ISolucionadorIoC solucionadorIoC, object obj) : base(solucionadorIoC, obj)
        {

        }
    }

    internal class DependenciaDescarteObjetoEmpacotado<T> : IDependenciaDescarteObjetoEmpacotado<T>
    {

        private readonly ISolucionadorIoC solucionadorIoC;

        public DependenciaDescarteObjetoEmpacotado(ISolucionadorIoC solucionadorIoC, T obj)
        {
            this.solucionadorIoC = solucionadorIoC;
            Objeto = obj;
        }

        public void Dispose()
        {
            this.solucionadorIoC.Lancamento(Objeto);
        }

        public T Objeto { get; }
    }

}