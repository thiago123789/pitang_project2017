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
        private readonly IAvaliacaoRepository avaliacaoRepository;
        private readonly IUsuarioRepository usuarioRepository;

        public ClienteService(ICartaoRepository cartaoRepository, IPedidoRepository pedidoRepository, IAvaliacaoRepository avaliacaoRepository, IUsuarioRepository usuarioRepository)
        {
            this.cartaoRepository = cartaoRepository;
            this.pedidoRepository = pedidoRepository;
            this.avaliacaoRepository = avaliacaoRepository;
            this.usuarioRepository = usuarioRepository;
        }
        public void AdicionarUmCartao(long idCliente, Cartao cartao)
        {
            Usuario cliente = this.usuarioRepository.GetOne(idCliente);
            cliente.Cartao.Add(cartao);
            cartao.Cliente = cliente;
            this.cartaoRepository.Add(cartao);
        }

        public void AvaliarPedido(long idPedido, Avaliacao avaliacao)
        {
            Pedido pedido = this.pedidoRepository.GetOne(idPedido);
            pedido.Avaliacao = avaliacao;
            this.avaliacaoRepository.Add(avaliacao);
        }

        public void CancelarPedido(long idPedido)
        {
            Pedido pedido = this.pedidoRepository.GetOne(idPedido);
            pedido.StatusPedido = StatusPedido.Cancelado;
        }

        public void FazerPedido(long idCliente, Pedido pedido)
        {
            Usuario cliente = this.usuarioRepository.GetOne(idCliente);
            cliente.Pedido.Add(pedido);
            pedido.Cliente = cliente;
            this.pedidoRepository.Add(pedido);

        }

        public void RealizarPagamento(long idPedido, Pagamento pagamento)
        {
            Pedido pedido = this.pedidoRepository.GetOne(idPedido);
            pedido.Pagamento = pagamento;
        }

    }
}
