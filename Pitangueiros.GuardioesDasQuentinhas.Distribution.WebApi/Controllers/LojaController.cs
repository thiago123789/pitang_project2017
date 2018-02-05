using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Pitangueiros.GuardioesDasQuentinhas.App.Contracts;
using Pitangueiros.GuardioesDasQuentinhas.App.Entities;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;

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

        [HttpGet]
        public ListarPorcoesDaLojaOutputDto ListarPorcoesLoja(int idLoja)
        {
            IList<Porcao> porcoes = this.lojaAppService.ListarPorcoesLoja(idLoja);
            IList<PorcaoOutputDto> porcoesDtos = new List<PorcaoOutputDto>();

            foreach (Porcao porcao in porcoes)
            {
                PorcaoOutputDto porcaoOutput = new PorcaoOutputDto();
                porcaoOutput.Item = porcao.Item;
                porcaoOutput.Quantidade = porcao.Quantidade;
                porcaoOutput.Preco = porcao.Preco;
                porcaoOutput.CategoriaPorcao = porcao.CategoriaPorcao;
                porcaoOutput.DataCriacao = porcao.DataCriacao;
                porcaoOutput.UltimaModificacao = porcao.UltimaModificacao;
                porcaoOutput.Id = porcao.Id;
                porcoesDtos.Add(porcaoOutput);
            };

            return new ListarPorcoesDaLojaOutputDto
            {
                idLoja = idLoja,
                Porcoes = porcoesDtos
            };
        }

        [HttpGet]
        public ListarPedidosDaLojaOutputDto ListarPedidosDaLoja(int idLoja)
        {
            IList<Pedido> listaPedidos = this.lojaAppService.ListarPedidosLoja(idLoja);
            IList<PedidoOutputDto> listaPedidoDto = new List<PedidoOutputDto>();

            foreach (Pedido pedido in listaPedidos)
            {
                PedidoOutputDto pedidoOutput = new PedidoOutputDto();
                pedidoOutput.StatusPedido = pedido.StatusPedido;
                pedidoOutput.Avaliacao = new AvaliacaoOutputDto();
                pedidoOutput.Comentario = pedido.Comentario;
                pedidoOutput.DataCriacao = pedido.DataCriacao;
                pedidoOutput.Pagamento = new PagamentoOutputDto();
                pedidoOutput.Preco = pedido.Preco;
                pedidoOutput.UltimaModificacao = pedido.UltimaModificacao;
            };

            return new ListarPedidosDaLojaOutputDto
            {
                idLoja = idLoja,
                Porcoes = porcoesDtos
            };

            return null;
        }
    }
}