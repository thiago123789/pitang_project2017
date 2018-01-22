using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using AutoMapper;
using Pitangueiros.GuardioesDasQuentinhas;
using Pitangueiros.GuardioesDasQuentinhas.Cross.IoC;
using Pitangueiros.GuardioesDasQuentinhas.Cross.IoC.Contracts;
using Pitangueiros.GuardioesDasQuentinhas.Cross.IoC.Contracts.Mapeador;
using Pitangueiros.GuardioesDasQuentinhas.Distribution.WebApi.IoC;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Repositories.IoC;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Services.IoC;
using Pitangueiros.GuardioesDasQuentinhas.App.Services.IoC;

namespace Pitangueiros.GuardioesDasQuentinhas.Distribution.WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GerenciadorIoC.Instancia
                .AdicionarConvencaoDeRegistro(new ConvecaoBasicaRegistrador());
            //Esperando implementar coisas da API para descomentar
            GerenciadorIoC.Instancia
                .AdicionarConvencaoDeRegistro(new RegistradorConvencionalApiController());
            //GlobalConfiguration.Configure(WebApiConfig.Register);
            GerenciadorIoC.Instancia
                .RegistrarAssemblyPorConvencao(Assembly.GetAssembly(typeof(InstaladorRepositorios)));
            GerenciadorIoC.Instancia
                .RegistrarAssemblyPorConvencao(Assembly.GetAssembly(typeof(InstaladorServicosDominio)));
            //Vai ser o Initializer de AppDomain?
            GerenciadorIoC.Instancia
                .RegistrarAssemblyPorConvencao(Assembly.GetAssembly(typeof(InstaladorAppService)));

            GerenciadorIoC.Instancia.RegistrarAssemblyPorConvencao(Assembly.GetExecutingAssembly());

            foreach (IInicializadorIoC inicializador in GerenciadorIoC.Instancia.SolucionarTudo<IInicializadorIoC>())
            {
                inicializador.Inicializar(GerenciadorIoC.Instancia);
            }

            foreach (IPerfilMapeador pMapeador in GerenciadorIoC.Instancia.SolucionarTudo<IPerfilMapeador>() )
            {
                if (pMapeador is Profile profile)
                {
                    Mapper.Initialize(config => config.AddProfile(profile));
                }
            }

            //Temos que dar uma olhada no Register do Blog para conseguir replicar.
            GlobalConfiguration.Configure(WebApiConfig.Register);

        }


        protected void Application_End()
        {
            GerenciadorIoC.Instancia.Dispose();
        }
    }
}