﻿using System;
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
        public void ExcluirPorcaoDaLoja(int idPorcao)
        {
            this.lojaAppService.ExcluirPorcaoDaLoja(idPorcao);
        }

        [HttpPut]
        public void ExcluirBairroDeEntrega(int idBairro)
        {
            this.lojaAppService.ExcluirBairroDeEntrega(idBairro);
        }

        [HttpPut]
        public void AtualizarStatusDoPedido(AtualizarStatusInputDto atualizarStatus)
        {
            this.lojaAppService.AtualizarStatusDoPedido(atualizarStatus);
        }

        [HttpPost]
        public void CriarNovoPrato(PratoInputDto prato)
        {
            this.lojaAppService.CriarNovoPrato(prato);
        }

        [HttpPost]
        public void AdicionarBairroDeEntrega(BairroInputDto bairro)
        {
            this.lojaAppService.AdicionarBairroDeEntrega(bairro);
        }
    }
}