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
            this.cartaoRepository.Save(cartao);
        }

        public void AvaliarLoja(Loja loja, Avaliacao avaliacao)
        {
            avaliacao.Loja = loja;
        }

        public void CancelarPedido(long id)
        {
            Pedido pedido = this.pedidoRepository.GetOne(id);
            pedido.StatusPedido = StatusPedido.Cancelado;
        }

        public void FazerPedido(Pedido pedido)
        {
            this.pedidoRepository.Save(pedido);
        }

        public void RealizarPagamento(Pedido pedido, Pagamento pagamento)
        {
            pedido.Pagamento = pagamento;
        }
        public void EscolherOpcaoDePagamento(Pagamento pagamento, OpcaoDePagamento opcaoDePagamento)
        {
            if (pagamento != null) pagamento.OpcaoDePagamento = opcaoDePagamento;
        }

        //public void EscolherLoja(Loja loja)
        //{
        //    throw new NotImplementedException();
        //}

        //public void EscolherPrato(Prato prato)
        //{
        //    throw new NotImplementedException();
        //}

        //public void PersonalizarPrato(Prato prato)
        //{
        //    throw new NotImplementedException();
        //}

        public void FazerComentarioEmPedido(Pedido pedido, string comentario)
        {
            pedido.Comentario = comentario;
        }
    }
}
