using System.Reflection;
using Castle.MicroKernel.Registration;
using Pitangueiros.GuardioesDasQuentinhas.Cross.IoC.Contracts.Mapeador;

namespace Pitangueiros.GuardioesDasQuentinhas.Cross.IoC.Contracts
{
    public class RegistradorMapeadorAutomanticoConvencional : IConvencaoDependenciaRegistro
    {
        public void RegistrarAssembly(IContextoConvencionalRegistracao contexto)
        {
            contexto.GerenciadorIoC.ContainerIoC.Register(
                Classes.FromAssembly(contexto.Assembly)
                    .IncludeNonPublicTypes()
                    .BasedOn<IPerfilMapeador>()
                    .If(type => !type.GetTypeInfo().IsGenericTypeDefinition)
                    .WithService.Base()
                    .LifestyleSingleton()
                );
        }
    }
}