using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Services;
using Pitangueiros.GuardioesDasQuentinhas.App.Contracts;
using Pitangueiros.GuardioesDasQuentinhas.App.Entities;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;


namespace Pitangueiros.GuardioesDasQuentinhas.App.Services.Impl
{
    class ClienteAppService : IClienteAppService
    {
        IClienteService clienteService;
        public ClienteAppService(IClienteService clienteService)
        {
            this.clienteService = clienteService;
        }

        public void EscolherLoja(LojaInputDto loja)
        {
            throw new NotImplementedException();
            //this.clienteService.EscolherLoja(); 
        }
        public void FazerPedido(FazerPedidoInputDto fazerPedido) {
            throw new NotImplementedException();
        }

        void CancelarPedido(Pedido pedido) {
            throw new NotImplementedException();
        }

        void AdicionarUmCartao(Cartao cartao) {
            throw new NotImplementedException();
        }

        void FazerComentarioEmPedido(Pedido pedido, string comentario) {
            throw new NotImplementedException();
        }
        void RealizarPagamento(Pedido pedido, Pagamento pagamento) {
            throw new NotImplementedException();
        }
        void AvaliarLoja(Loja loja, Avaliacao avaliacao) {
            throw new NotImplementedException();
        }

        public void EscolherPrato()
        {
            throw new NotImplementedException();
        }

        public void PersonalizarPrato()
        {
            throw new NotImplementedException();
        }

        public void CancelarPedido(CancelarPedidoInputDto cancelarPedido)
        {
            throw new NotImplementedException();
        }

        public void AdicionarUmCartao(CartaoInputDto cartaoInput)
        {
            throw new NotImplementedException();
        }

        public void FazerComentarioEmPedido(FazerComentarioInputDto comentario)
        {
            throw new NotImplementedException();
        }

        public void RealizarPagamento(RealizarPagamentoInputDto pagar)
        {
            throw new NotImplementedException();
        }

        public void AvaliarLoja(AvaliarLojaInputDto avaliacao)
        {
            throw new NotImplementedException();
        }
    }
}
