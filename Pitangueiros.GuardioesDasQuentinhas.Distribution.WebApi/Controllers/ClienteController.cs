using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Pitangueiros.GuardioesDasQuentinhas.App.Contracts;
using Pitangueiros.GuardioesDasQuentinhas.App.Entities;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.Distribution.WebApi.Controllers
{
    public class ClienteController : ApiController
    {
        private readonly IClienteAppService clienteAppService;

        public ClienteController(IClienteAppService clienteAppService)
        {
            this.clienteAppService = clienteAppService;
        }

        [HttpPost]
        public void FazerPedido(PedidoInputDto pedido)
        {
            this.clienteAppService.FazerPedido(pedido);
        }

        [HttpPost]
        public void CriarPratoEmPedido(PratoClienteInputDto pratoCliente)
        {
            this.clienteAppService.CriarPratoEmPedido(pratoCliente);
        }

        [HttpPost]
        public void InserirPratoNoPedido(InserirPratoInputDto inserirPrato)
        {
            this.clienteAppService.InserirPratoNoPedido(inserirPrato);
        }

        [HttpPost]
        public void AdicionarUmCartao(CartaoInputDto cartao)
        {
            this.clienteAppService.AdicionarUmCartao(cartao);
        }

        [HttpPut]
        public void CancelarPedido(long idPedido)
        {
            this.clienteAppService.CancelarPedido(idPedido);
        }

        [HttpPut]
        public void DesativarCartao(int idCartao)
        {
            this.clienteAppService.DesativarCartao(idCartao);
        }

        [HttpPut]
        public void AtualizarCartao(AtualizarCartaoInputDto atualizarCartao)
        {
            this.clienteAppService.AtualizarCartao(atualizarCartao);
        }

        [HttpGet]
        public ListarLojasOutputDto ListarLojas()
        {
            IList<Loja> lojas = this.clienteAppService.ListarLojas();

            IList<LojaOutputDto> lojasOutput = new List<LojaOutputDto>();

            foreach (Loja loja in lojas)
            {
                LojaOutputDto lojaOutput = new LojaOutputDto();
                lojaOutput.Id = loja.Id;
                lojaOutput.Nome = loja.Nome;
                lojaOutput.EnderecoDaLoja = loja.EnderecoDaLoja;
                lojaOutput.MediaAvaliacoes = loja.MediaAvaliacoes;
                lojaOutput.DataCriacao = loja.DataCriacao;
                lojaOutput.UltimaModificacao = loja.UltimaModificacao;
                lojasOutput.Add(lojaOutput);

            }

            return new ListarLojasOutputDto
            {
                Lojas = lojasOutput
            };
        }

        [HttpGet]
        public ListarPorcoesDaLojaOutputDto ListarPorcoesDaLojas(int idLoja)
        {
            IList<Porcao> porcoes = this.clienteAppService.ListarPorcoesDaLoja(idLoja);

            IList<PorcaoOutputDto> porcoesOutput = new List<PorcaoOutputDto>();

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
                porcoesOutput.Add(porcaoOutput);
            }; 

            return new ListarPorcoesDaLojaOutputDto
            {
                idLoja = idLoja,
                Porcoes = porcoesOutput
            };
        }
    }
}