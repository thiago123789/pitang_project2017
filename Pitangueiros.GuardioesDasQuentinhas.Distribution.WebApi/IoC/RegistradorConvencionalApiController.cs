using System.Reflection;
using System.Web.Http;
using Castle.MicroKernel.Registration;
using Pitangueiros.GuardioesDasQuentinhas.Cross.IoC.Contracts;

namespace Pitangueiros.GuardioesDasQuentinhas.Distribution.WebApi.IoC
{
    public class RegistradorConvencionalApiController : IConvencaoDependenciaRegistro
    {
        public void RegistrarAssembly(IContextoConvencionalRegistracao contexto)
        {
            contexto.GerenciadorIoC.ContainerIoC.Register(
                Classes.FromAssembly(contexto.Assembly)
                    .BasedOn<ApiController>()
                    .If(type => !type.GetTypeInfo().IsGenericTypeDefinition)
                    .LifestyleTransient()
            );
        }
    }
}