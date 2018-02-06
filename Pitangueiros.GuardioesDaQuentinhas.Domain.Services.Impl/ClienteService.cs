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
        private readonly IPorcaoRepository porcaoRepository;
        private readonly IPratoRepository pratoRepository;

        public ClienteService(ICartaoRepository cartaoRepository, ILojaRepository lojaRepository, 
                              IPedidoRepository pedidoRepository, IAvaliacaoRepository avaliacaoRepository, 
                              IUsuarioRepository usuarioRepository, IPorcaoRepository porcaoRepository,
                              IPratoRepository pratoRepository)
        {
            this.cartaoRepository = cartaoRepository;
            this.lojaRepository = lojaRepository;
            this.pedidoRepository = pedidoRepository;
            this.avaliacaoRepository = avaliacaoRepository;
            this.usuarioRepository = usuarioRepository;
            this.porcaoRepository = porcaoRepository;
            this.pratoRepository = pratoRepository;

        }
        public void AdicionarUmCartao(long idCliente, Cartao cartao)
        {
            Usuario cliente = this.usuarioRepository.Find(idCliente);
            cliente.Cartoes.Add(cartao);
            cartao.Cliente = cliente;
            this.usuarioRepository.Save();
        }

        public void AvaliarPedido(long idPedido, Avaliacao avaliacao)
        {
            Pedido pedido = this.pedidoRepository.Find(idPedido);
            pedido.Avaliacao = avaliacao;
            avaliacao.Pedido = pedido;
            this.pedidoRepository.Save();
        }

        public void CancelarPedido(long idPedido)
        {
            Pedido pedido = this.pedidoRepository.Find(idPedido);
            pedido.StatusPedido = StatusPedido.Cancelado;
            this.pedidoRepository.Save();
        }

        public void CriarPratoEmPedido(long idPedido, IList<long> idPorcoes, Prato prato)
        {
            Pedido pedido = this.pedidoRepository.Find(idPedido);
            IList<Porcao> porcoes = this.porcaoRepository.FindList(idPorcoes);
            prato.Porcoes = porcoes;
            pedido.Pratos.Add(prato);
            foreach (Porcao porcao in porcoes)
            {
                prato.Preco = prato.Preco + porcao.Preco;
            }
            this.porcaoRepository.Save();
        }

        public void InserirPratoNoPedido(IList<int> idPratos, long idPedido, string comentario)
        {
            Pedido pedido = this.pedidoRepository.Find(idPedido);
            IList<Prato> pratos = this.pratoRepository.FindList(idPratos);
            pedido.Comentario = comentario;
            pedido.Pratos = pratos;
            this.pratoRepository.Save();
        }

        public void FazerPedido(long idCliente, int idLoja, Pedido pedido)
        {

            Usuario cliente = this.usuarioRepository.Find(idCliente);
            pedido.Cliente = cliente;
            cliente.Pedidos.Add(pedido);
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

        public void DesativarCartao(int idCartao)
        {
            Cartao cartao = this.cartaoRepository.Find(idCartao);
            this.cartaoRepository.Desativar(cartao);
            this.cartaoRepository.Save();
        }

        public void AtualizarCartao(int idCartao, Cartao cartaoAtualizado)
        {
            Cartao cartao = cartaoRepository.Find(idCartao);
            if (cartaoAtualizado.NomeTitular != null)
            {
                cartao.NomeTitular = cartaoAtualizado.NomeTitular;
            }

            if (cartaoAtualizado.Bandeira != null)
            {
                cartao.Bandeira = cartaoAtualizado.Bandeira;
            }
            if (cartaoAtualizado.CodSeg != null)
            {
                cartao.CodSeg = cartaoAtualizado.CodSeg;
            }
            if (cartaoAtualizado.Validade != null)
            {
                cartao.Validade = cartaoAtualizado.Validade;
            }
            if (cartaoAtualizado.Numero != null)
            {
                cartao.Numero = cartaoAtualizado.Numero;
            }
            this.cartaoRepository.Save();
        }

        public IList<Porcao> ListarPorcoesLoja(int idLoja)
        {
            IList<Porcao> porcoes = this.lojaRepository.Find(idLoja).Porcoes;
            this.lojaRepository.Save();
            return porcoes;
        }

        public IList<Cartao> ListarCartoesCliente(long idCliente)
        {
            IList<Cartao> cartoes = this.usuarioRepository.Find(idCliente).Cartoes;
            this.usuarioRepository.Save();
            return cartoes;
        }

        public IList<Pedido> ListarPedidosCliente(long idCliente)
        {
            IList<Pedido> pedidos = this.usuarioRepository.Find(idCliente).Pedidos;
            this.usuarioRepository.Save();
            return pedidos;
        }
    }
}

