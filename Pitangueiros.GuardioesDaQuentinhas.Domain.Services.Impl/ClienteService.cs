using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Services;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Repositories;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Services.Impl
{
    public class ClienteService : IClienteService
    {
        private readonly ICartaoRepository cartaoRepository;
        private readonly IPedidoRepository pedidoRepository;

        public ClienteService(ICartaoRepository cartaoRepository, IPedidoRepository pedidoRepository)
        {
            this.cartaoRepository = cartaoRepository;
            this.pedidoRepository = pedidoRepository;
        }
        public void AdicionarUmCartao(Cartao cartao)
        {
            cartaoRepository.Save(cartao);
        }

        public void AvaliarLoja(Loja loja, Avaliacao avaliacao)
        {
            avaliacao.Loja = loja;
        }

        public void CancelarPedido(Pedido pedido)
        {
            pedido.StatusPedido = StatusPedido.Cancelado;
        }

        public void FazerComentarioEmPedido(Pedido pedido, Comentario comentario)
        {
            pedido.Comentario = comentario;
        }

        public void FazerPedido(Pedido pedido)
        {
            pedidoRepository.Save(pedido);
        }

        public void RealizarPagamento(Pedido pedido, Pagamento pagamento)
        {
            pedido.Pagamento = pagamento;
        }
        public void EscolherOpcaoDePagamento(Pagamento pagamento, OpcaoDePagamento opcaoDePagamento)
        {
            if (pagamento != null) pagamento.OpcaoDePagamento = opcaoDePagamento;
        }
    }
}
