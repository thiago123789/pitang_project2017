using System.Reflection;
using Castle.DynamicProxy;
using Castle.MicroKernel.Registration;

namespace Pitangueiros.GuardioesDasQuentinhas.Cross.IoC.Contracts
{
    public class ConvecaoBasicaRegistrador : IConvencaoDependenciaRegistro
    {
        public void RegistrarAssembly(IContextoConvencionalRegistracao contexto)
        {
            contexto.GerenciadorIoC.ContainerIoC.Register(
                Classes.FromAssembly(contexto.Assembly)
                    .IncludeNonPublicTypes()
                    .BasedOn<IDependenciaTransient>()
                    .If(type => !type.GetTypeInfo().IsGenericTypeDefinition)
                    .WithService.Self()
                    .WithService.DefaultInterfaces()
                    .LifestyleTransient()
                );

            contexto.GerenciadorIoC.ContainerIoC.Register(
                Classes.FromAssembly(contexto.Assembly)
                    .IncludeNonPublicTypes()
                    .BasedOn<IDependenciaSingleton>()
                    .If(type => !type.GetTypeInfo().IsGenericTypeDefinition)
                    .WithService.Self()
                    .WithService.DefaultInterfaces()
                    .LifestyleSingleton()
            );

            contexto.GerenciadorIoC.ContainerIoC.Register(
                Classes.FromAssembly(contexto.Assembly)
                    .IncludeNonPublicTypes()
                    .BasedOn<IInterceptor>()
                    .If(type => !type.GetTypeInfo().IsGenericTypeDefinition)
                    .WithService.Self()
                    //.WithService.DefaultInterfaces()
                    .LifestyleTransient()
            );



        }

    }
}