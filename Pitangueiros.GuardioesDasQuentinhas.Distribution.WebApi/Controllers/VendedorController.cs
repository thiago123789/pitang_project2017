using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using Pitangueiros.GuardioesDasQuentinhas.App.Contracts;
using Pitangueiros.GuardioesDasQuentinhas.App.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.Distribution.WebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class VendedorController: ApiController
    {
        private readonly IVendedorAppService vendedorAppService;
        public VendedorController(IVendedorAppService vendedorAppService)
        {
            this.vendedorAppService = vendedorAppService;
        }

        [HttpPost]
        public void CadrastarLoja(LojaInputDto loja)
        {
            this.vendedorAppService.CadastrarLoja(loja);
        }

        [HttpPost]
        public void AtualizarLoja(AtualizarLojaInputDto atualizarLoja)
        {
            this.vendedorAppService.AtualizarLoja(atualizarLoja);
        }

        [HttpPut]
        public void DesativarLoja(int idLoja)
        {
            this.vendedorAppService.DesativarLoja(idLoja);
        }
    }
}