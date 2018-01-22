using System;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;
using Pitangueiros.GuardioesDasQuentinhas.Cross.IoC.Contracts;
using Pitangueiros.GuardioesDasQuentinhas.Cross.IoC.Extensions;

namespace Pitangueiros.GuardioesDasQuentinhas.Distribution.WebApi.IoC
{
    public class AtivadorControladorApi : IHttpControllerActivator
    {
        private readonly ISolucionadorIoC _solucionadorIoC;

        public AtivadorControladorApi(ISolucionadorIoC iocResolver)
        {
            this._solucionadorIoC = iocResolver;
        }

        public IHttpController Create(HttpRequestMessage request, HttpControllerDescriptor controllerDescriptor, Type controllerType)
        {
            var controllerWrapper = _solucionadorIoC.ResolveAsDisposable<IHttpController>(controllerType);
            request.RegisterForDispose(controllerWrapper);
            return controllerWrapper.Objeto;
        }
    }
}