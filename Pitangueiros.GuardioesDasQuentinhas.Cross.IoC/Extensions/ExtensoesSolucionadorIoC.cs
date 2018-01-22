using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Cross.IoC.Contracts;

namespace Pitangueiros.GuardioesDasQuentinhas.Cross.IoC.Extensions
{
    public static class IExtensoesSolucionadorIoC
    {
        public static IDependenciaDescarteObjetoEmpacotado<T> ResolveAsDisposable<T>(this ISolucionadorIoC iocResolver)
        {
            return new DependenciaDescarteObjetoEmpacotado<T>(iocResolver, iocResolver.Solucionar<T>());
        }

        public static IDependenciaDescarteObjetoEmpacotado<T> ResolveAsDisposable<T>(this ISolucionadorIoC iocResolver, Type type)
        {
            return new DependenciaDescarteObjetoEmpacotado<T>(iocResolver, (T)iocResolver.Solucionar(type));
        }
        public static IDependenciaDescarteObjetoEmpacotado ResolveAsDisposable(this ISolucionadorIoC iocResolver, Type type)
        {
            return new DependenciaDescarteObjetoEmpacotado(iocResolver, iocResolver.Solucionar(type));
        }

        public static IDependenciaDescarteObjetoEmpacotado<T> ResolveAsDisposable<T>(this ISolucionadorIoC iocResolver, object argumentsAsAnonymousType)
        {
            return new DependenciaDescarteObjetoEmpacotado<T>(iocResolver, iocResolver.Solucionar<T>(argumentsAsAnonymousType));
        }

        public static IDependenciaDescarteObjetoEmpacotado<T> ResolveAsDisposable<T>(this ISolucionadorIoC iocResolver, Type type, object argumentsAsAnonymousType)
        {
            return new DependenciaDescarteObjetoEmpacotado<T>(iocResolver, (T)iocResolver.Solucionar(type, argumentsAsAnonymousType));
        }

        public static IDependenciaDescarteObjetoEmpacotado ResolveAsDisposable(this ISolucionadorIoC iocResolver, Type type, object argumentsAsAnonymousType)
        {
            return new DependenciaDescarteObjetoEmpacotado(iocResolver, iocResolver.Solucionar(type, argumentsAsAnonymousType));
        }

        public static void Using<T>(this ISolucionadorIoC iocResolver, Action<T> action)
        {
            using (var wrapper = iocResolver.ResolveAsDisposable<T>())
            {
                action(wrapper.Objeto);
            }
        }

        public static TReturn Using<TService, TReturn>(this ISolucionadorIoC iocResolver, Func<TService, TReturn> func)
        {
            using (var obj = iocResolver.ResolveAsDisposable<TService>())
            {
                return func(obj.Objeto);
            }
        }

    }
}
