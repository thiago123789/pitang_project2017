using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Pitangueiros.GuardioesDasQuentinhas.App.Contracts;
using Pitangueiros.GuardioesDasQuentinhas.App.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.Distribution.WebApi.Controllers
{
    public class VendedorController: ApiController
    {
        private readonly IVendedorAppService appServiceVendedor;
        public VendedorController(IVendedorAppService appServiceVendedor)
        {
            this.appServiceVendedor = appServiceVendedor;
        }
    }
}