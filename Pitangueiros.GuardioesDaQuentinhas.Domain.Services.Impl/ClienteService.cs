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
        private readonly IClienteRepository clienteRepository;

        public ClienteService(ICartaoRepository cartaoRepository, IPedidoRepository pedidoRepository, IAvaliacaoRepository avaliacaoRepository, IClienteRepository clienteRepository)
        {
            this.cartaoRepository = cartaoRepository;
            this.pedidoRepository = pedidoRepository;
            this.avaliacaoRepository = avaliacaoRepository;
            this.clienteRepository = clienteRepository;
        }
        public void AdicionarUmCartao(long idCliente, Cartao cartao)
        {
            Cliente cliente = this.clienteRepository.GetOne(idCliente);
            cliente.Cartao.Add(cartao);
            cartao.Cliente = cliente;
            this.clienteRepository.Update(cliente);
            this.cartaoRepository.Save(cartao);
        }

        public void AvaliarPedido(long idPedido, Avaliacao avaliacao)
        {
            Pedido pedido = this.pedidoRepository.GetOne(idPedido);
            pedido.Avaliacao = avaliacao;
            this.pedidoRepository.Update(pedido);
            this.avaliacaoRepository.Save(avaliacao);
        }

        public void CancelarPedido(long idPedido)
        {
            Pedido pedido = this.pedidoRepository.GetOne(idPedido);
            pedido.StatusPedido = StatusPedido.Cancelado;
            this.pedidoRepository.Update(pedido);
        }

        public void FazerPedido(long idCliente, Pedido pedido)
        {
            Cliente cliente = this.clienteRepository.GetOne(idCliente);
            cliente.Pedido.Add(pedido);
            pedido.Cliente = cliente;
            this.clienteRepository.Update(cliente);
            this.pedidoRepository.Save(pedido);

        }

        public void RealizarPagamento(long idPedido, Pagamento pagamento)
        {
            Pedido pedido = this.pedidoRepository.GetOne(idPedido);
            pedido.Pagamento = pagamento;
            this.pedidoRepository.Update(pedido);
        }

    }
}
