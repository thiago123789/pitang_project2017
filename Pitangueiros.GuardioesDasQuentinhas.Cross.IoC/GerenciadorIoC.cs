using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Windsor.Installer;

namespace Pitangueiros.GuardioesDasQuentinhas.Cross.IoC.Contracts
{
    public class GerenciadorIoC : IGerenciadorIoC { 

        public static GerenciadorIoC Instancia { get; private set; }

        static GerenciadorIoC()
        {
            Instancia = new GerenciadorIoC();
        }
        
        public IWindsorContainer ContainerIoC { get; private set; }

        private readonly List<IConvencaoDependenciaRegistro> convencaoDeRegistros;

        public GerenciadorIoC()
        {
            ContainerIoC = new WindsorContainer();
            convencaoDeRegistros = new List<IConvencaoDependenciaRegistro>();

            ContainerIoC.Register(
                Component.For<GerenciadorIoC, IGerenciadorIoC, IRegistradorIoC, ISolucionadorIoC>()
                .UsingFactoryMethod(() => this)
            );
        }

        public void AdicionarConvencaoDeRegistro(IConvencaoDependenciaRegistro registrador)
        {
            convencaoDeRegistros.Add(registrador);
        }

        public void RegistrarAssemblyPorConvencao(Assembly assembly)
        {
            RegistrarAssemblyPorConvencao(assembly, new ConfiguracaoConvencionalRegistro());
        }

        public void RegistrarAssemblyPorConvencao(Assembly assembly, ConfiguracaoConvencionalRegistro config)
        {
            var contexto = new ContextoConvencionalRegistro(assembly, this, config);

            foreach (var registrador in convencaoDeRegistros)
            {
                registrador.RegistrarAssembly(contexto);
            }

            if (config.InstalarInstaladores)
            {
                ContainerIoC.Install(FromAssembly.Instance(assembly));
            }

        }

        public void Registrar<T>(EstiloDeVidaDependencia estiloDeVida = EstiloDeVidaDependencia.Singleton) where T : class
        {
            ContainerIoC.Register(AplicarEstiloDeVida(Component.For<T>(), estiloDeVida));
        }

        public void Registrar(Type tipo, EstiloDeVidaDependencia estiloDeVida = EstiloDeVidaDependencia.Singleton)
        {
            ContainerIoC.Register(AplicarEstiloDeVida(Component.For(tipo), estiloDeVida));
        }

        public void Registrar<TTipo, TImpl>(EstiloDeVidaDependencia estiloDeVida = EstiloDeVidaDependencia.Singleton) where TTipo : class where TImpl : class, TTipo
        {
            ContainerIoC.Register(AplicarEstiloDeVida(Component.For<TTipo, TImpl>(), estiloDeVida));
        }

        public void Registrar(Type tipo, Type impl, EstiloDeVidaDependencia estiloDeVida = EstiloDeVidaDependencia.Singleton)
        {
            ContainerIoC.Register(AplicarEstiloDeVida(Component.For(tipo, impl).ImplementedBy(impl), estiloDeVida));
        }

        public bool EstaRegistrado(Type type)
        {
            return ContainerIoC.Kernel.HasComponent(type);
        }

        public bool EstaRegistrado<T>()
        {
            return ContainerIoC.Kernel.HasComponent(typeof(T));
        }

        public T Solucionar<T>()
        {
            return ContainerIoC.Resolve<T>();
        }

        public T Solucionar<T>(Type tipo)
        {
            return (T) ContainerIoC.Resolve(tipo);
        }

        public T Solucionar<T>(object argumentoComoTipoAnonimo)
        {
            return ContainerIoC.Resolve<T>(argumentoComoTipoAnonimo);
        }

        public object Solucionar(Type tipo)
        {
            return ContainerIoC.Resolve(tipo);
        }

        public object Solucionar(Type tipo, object argumentoComoTipoAnonimo)
        {
            return ContainerIoC.Resolve(tipo, argumentoComoTipoAnonimo);
        }

        public T[] SolucionarTudo<T>()
        {
            return ContainerIoC.ResolveAll<T>();
        }

        public T[] SolucionarTudo<T>(object argumentoComoTipoAnonimo)
        {
            return ContainerIoC.ResolveAll<T>(argumentoComoTipoAnonimo);
        }

        public object[] SolucionarTudo(Type tipo)
        {
            return ContainerIoC.ResolveAll(tipo).Cast<object>().ToArray();
        }

        public object[] SolucionarTudo(Type tipo, object argumentoComoTipoAnonimo)
        {
            return ContainerIoC.ResolveAll(tipo, argumentoComoTipoAnonimo).Cast<object>().ToArray();
        }

        public void Lancamento(object obj)
        {
            ContainerIoC.Release(obj);
        }

        public void Dispose()
        {
            ContainerIoC.Dispose();
        }

        private static ComponentRegistration<T> AplicarEstiloDeVida<T>(ComponentRegistration<T> registracao,
            EstiloDeVidaDependencia estiloDeVida)
            where T : class
        {
            switch (estiloDeVida){
                case EstiloDeVidaDependencia.Singleton:
                    return registracao.LifestyleSingleton();
                case EstiloDeVidaDependencia.Transient:
                    return registracao.LifestyleTransient();
                default:
                    return registracao;
            }

        }

    }
}