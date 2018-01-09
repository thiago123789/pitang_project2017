using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy.Generators.Emitters;

namespace Pitangueiros.GuardioesDasQuentinhas.Cross.IoC.Contracts
{
    public interface IRegistradorIoC
    {
        void AdicionarConvencaoDeRegistro(IConvencaoDependenciaRegistro registrador);

        void RegistrarAssemblyPorConvencao(Assembly assembly);

        void RegistrarAssemblyPorConvencao(Assembly assembly, ConfiguracaoConvencionalRegistro config);

        void Registrar<T>(EstiloDeVidaDependencia estiloDeVida = EstiloDeVidaDependencia.Singleton)
            where T : class;

        void Registrar(Type tipo, EstiloDeVidaDependencia estiloDeVida = EstiloDeVidaDependencia.Singleton);

        void Registrar<TTipo, TImpl>(EstiloDeVidaDependencia estiloDeVida = EstiloDeVidaDependencia.Singleton)
            where TTipo : class
            where TImpl : class, TTipo;

        void Registrar(Type tipo, Type impl, EstiloDeVidaDependencia estiloDeVida = EstiloDeVidaDependencia.Singleton);

        bool EstaRegistrado(Type tipo);

        bool EstaRegistrado<TTipo>();

    }
}
