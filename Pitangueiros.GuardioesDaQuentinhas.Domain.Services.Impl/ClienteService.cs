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
        private readonly ILojaRepository lojaRepository;
        private readonly IPedidoRepository pedidoRepository;
        private readonly IAvaliacaoRepository avaliacaoRepository;
        private readonly IUsuarioRepository usuarioRepository;
        private readonly IPagamentoRepository pagamentoRepository;
        private readonly IPratoRepository pratoRepository;

        public ClienteService(ICartaoRepository cartaoRepository, ILojaRepository lojaRepository, IPedidoRepository pedidoRepository, IAvaliacaoRepository avaliacaoRepository, IUsuarioRepository usuarioRepository)
        {
            this.cartaoRepository = cartaoRepository;
            this.lojaRepository = lojaRepository;
            this.pedidoRepository = pedidoRepository;
            this.avaliacaoRepository = avaliacaoRepository;
            this.usuarioRepository = usuarioRepository;
        }
        public void AdicionarUmCartao(long idCliente, Cartao cartao)
        {
            Usuario cliente = this.usuarioRepository.Find(idCliente);
            cliente.Cartao.Add(cartao);
            cartao.Cliente = cliente;
            this.usuarioRepository.Save();
        }

        public void AvaliarPedido(long idPedido, Avaliacao avaliacao)
        {
            Pedido pedido = this.pedidoRepository.GetOne(idPedido);
            pedido.Avaliacao = avaliacao;
            avaliacao.Pedido = pedido;
            this.pedidoRepository.Save();
        }

        public void CancelarPedido(long idPedido)
        {
            Pedido pedido = this.pedidoRepository.GetOne(idPedido);
            pedido.StatusPedido = StatusPedido.Cancelado;
            this.pedidoRepository.Save();
        }

        public void FazerPedido(long idCliente, int idLoja, Pedido pedido)
        {

            Usuario cliente = this.usuarioRepository.Find(idCliente);
            pedido.Cliente = cliente;
            cliente.Pedidos.Add(pedido);
            this.usuarioRepository.Save();
            Loja loja = this.lojaRepository.Find(idLoja);
            pedido.Loja = loja;
            loja.Pedidos.Add(pedido);
            this.lojaRepository.Save();

        }

        public void RealizarPagamento(long idPedido, Pagamento pagamento)
        {
            Pedido pedido = this.pedidoRepository.Find(idPedido);
            pedido.Pagamento = pagamento;
            pagamento.Pedido = pedido;
            this.pedidoRepository.Save();
        }

    }
}

