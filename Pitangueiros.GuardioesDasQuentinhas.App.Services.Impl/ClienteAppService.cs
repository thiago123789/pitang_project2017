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
        private readonly IClienteService clienteService;
        public ClienteAppService(IClienteService clienteService)
        {
            this.clienteService = clienteService;
        }

        public void AdicionarUmCartao(CartaoInputDto cartao)
        {
            this.clienteService.AdicionarUmCartao(new Cartao
            {
                NomeTitular = cartao.NomeTitular,
                Bandeira = cartao.Bandeira,
                CodSeg = cartao.CodSeg,
                Validade = cartao.Validade,
                Numero = cartao.Numero
            });
        }

        public void AvaliarPedido(AvaliacaoInputDto avaliacao)
        {
            this.clienteService.AvaliarPedido(avaliacao.Pedido, new Avaliacao
            {
                Nota = avaliacao.Nota,
                Comentario = avaliacao.Comentario
            });
        }

        public void CancelarPedido(CancelarPedidoInputDto id)
        {
            this.clienteService.CancelarPedido(id.Id);
        }

        public void FazerComentarioEmPedido(ComentarioInputDto comentario)
        {
            this.clienteService.FazerComentarioEmPedido(comentario.Pedido, comentario.Comentario);
        }

        public void FazerPedido(PedidoInputDto pedido)
        {
            this.clienteService.FazerPedido(new Pedido
            {
                Loja = pedido.Loja,
                Pratos = pedido.Pratos
            });
        }

        public void RealizarPagamento(PagamentoInputDto pagamento)
        {
            throw new NotImplementedException();
        }
    }
}
