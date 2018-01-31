using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Pitangueiros.GuardioesDasQuentinhas.App.Contracts;
using Pitangueiros.GuardioesDasQuentinhas.App.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.Distribution.WebApi.Controllers
{
    public class LojaController : ApiController
    {
        private readonly ILojaAppService lojaAppService;
        public LojaController(ILojaAppService lojaAppService)
        {
            this.lojaAppService = lojaAppService;
        }

        [HttpPost]
        public void CriarNovaPorcao(PorcaoInputDto porcao)
        {
            this.lojaAppService.CriarNovaPorcao(porcao);
        }

        [HttpPut]
        public void ExcluirPratoDaLoja(int idPrato)
        {
            this.lojaAppService.ExcluirPratoDaLoja(idPrato);
        }

        [HttpPut]
        public void AdicionarBairroDeEntrega(int idLoja, int idBairro)
        {
            this.lojaAppService.AdicionarBairroDeEntrega(idLoja, idBairro);
        }

        [HttpPut]
        public void ExcluirBairroDeEntrega(int idLoja, int idBairro)
        {
            this.lojaAppService.ExcluirBairroDeEntrega(idLoja, idBairro);
        }

        [HttpPost]
        public void CriarNovaPrato(PratoInputDto prato)
        {
            this.lojaAppService.CriarNovoPrato(prato);
        }

        [HttpPost]
        public void CadastrarBairro(BairroInputDto bairro)
        {
            this.lojaAppService.CadastrarBairro(bairro);
        }
    }
}