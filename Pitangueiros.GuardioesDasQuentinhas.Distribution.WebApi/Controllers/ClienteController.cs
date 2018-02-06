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

        [HttpPost]
        public void RealizarPagamento(PagamentoInputDto pagamento)
        {
            this.clienteAppService.RealizarPagamento(pagamento);
        }

        [HttpPost]
        public void AvaliarPedido(AvaliacaoInputDto avaliacao)
        {
            this.clienteAppService.AvaliarPedido(avaliacao);
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
        public ListarCartoesDoClienteOutputDto ListarCartoesCliente(long idCliente)
        {
            IList<Cartao> cartoes = this.clienteAppService.ListarCartoesCliente(idCliente);

            IList<CartaoOutputDto> cartoesOutput = new List<CartaoOutputDto>();

            foreach (Cartao cartao in cartoes)
            {
                CartaoOutputDto cartaoOutput = new CartaoOutputDto();
                cartaoOutput.Id = cartao.Id;
                cartaoOutput.NomeTitular = cartao.NomeTitular;
                cartaoOutput.Numero = cartao.Numero;
                cartaoOutput.Validade = cartao.Validade;
                cartaoOutput.CodSeg = cartao.CodSeg;
                cartaoOutput.DataCriacao = cartao.DataCriacao;
                cartaoOutput.UltimaModificacao = cartao.UltimaModificacao;
                cartoesOutput.Add(cartaoOutput);
            }
            return new ListarCartoesDoClienteOutputDto
            {
                IdCliente = idCliente,
                Cartoes = cartoesOutput
            };
        }

        [HttpGet]
        public ListarPedidosDoClienteOutputDto ListarPedidosCliente(long idCliente)
        {
            IList<Pedido> pedidos = this.clienteAppService.ListarPedidosCliente(idCliente);

            IList<PedidoOutputDto> pedidosOutput = new List<PedidoOutputDto>();

            foreach (Pedido pedido in pedidos)
            {
                PedidoOutputDto pedidoOutput = new PedidoOutputDto();
                pedidoOutput.Id = pedido.Id;
                pedidoOutput.StatusPedido = pedido.StatusPedido;
                pedidoOutput.Comentario = pedido.Comentario;
                pedidoOutput.DataCriacao = pedido.DataCriacao;
                pedidoOutput.Preco = pedido.Preco;
                pedidoOutput.UltimaModificacao = pedido.UltimaModificacao;
                pedidosOutput.Add(pedidoOutput);
            }
            return new ListarPedidosDoClienteOutputDto
            {
                IdCliente = idCliente,
                Pedidos = pedidosOutput
            };
        }
    }
}