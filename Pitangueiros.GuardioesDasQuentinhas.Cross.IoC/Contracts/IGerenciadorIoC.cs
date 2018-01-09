using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Windsor;

namespace Pitangueiros.GuardioesDasQuentinhas.Cross.IoC.Contracts{
    public interface IGerenciadorIoC: IRegistradorIoC, ISolucionadorIoC, IDisposable {
        IWindsorContainer ContainerIoC { get; }
        new bool EstaRegistrado(Type type);
        new bool EstaRegistrado<TTipo>();
    }
}
