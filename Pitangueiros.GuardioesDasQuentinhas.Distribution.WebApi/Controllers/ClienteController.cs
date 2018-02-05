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
        public void CancelarPedido(long idPedido)
        {
            this.clienteAppService.CancelarPedido(idPedido);
        }

        [HttpPost]
        public void DesativarCartao(int idCartao)
        {
            this.clienteAppService.DesativarCartao(idCartao);
        }

        [HttpPost]
        public void AtualizarCartao(AtualizarCartaoInputDto atualizarCartao)
        {
            this.clienteAppService.AtualizarCartao(atualizarCartao);
        }

        [HttpPost]
        public IList<Loja> ListarLojas()
        {
            return this.clienteAppService.ListarLojas();
        }

        [HttpPost]
        public ListarPorcoesDaLojaOutputDto ListarPorcoesDaLojas(int idLoja)
        {
            return new ListarPorcoesDaLojaOutputDto
            {
                idLoja = idLoja,
                Porcoes = this.clienteAppService.ListarPorcoesDaLoja(idLoja)
            };
        }
    }
}