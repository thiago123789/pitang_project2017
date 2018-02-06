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
    public class ClienteAppService : IClienteAppService
    {
        private readonly IClienteService clienteService;
        public ClienteAppService(IClienteService clienteService)
        {
            this.clienteService = clienteService;
        }

        public void AdicionarUmCartao(CartaoInputDto cartao)
        {
            this.clienteService.AdicionarUmCartao(cartao.IdCliente, new Cartao
            {
                NomeTitular = cartao.NomeTitular,
                Bandeira = cartao.Bandeira,
                CodSeg = cartao.CodSeg,
                Validade = cartao.Validade,
                Numero = cartao.Numero
            });
        }

        public void AtualizarCartao(AtualizarCartaoInputDto atualizarCartao)
        {
            this.clienteService.AtualizarCartao(atualizarCartao.IdCartao, new Cartao
            {
                NomeTitular = atualizarCartao.NomeTitular,
                Bandeira = atualizarCartao.Bandeira,
                CodSeg = atualizarCartao.CodSeg,
                Validade = atualizarCartao.Validade,
                Numero = atualizarCartao.Numero
            });
        }

        public void AvaliarPedido(AvaliacaoInputDto avaliacao)
        {
            this.clienteService.AvaliarPedido(avaliacao.IdPedido, new Avaliacao
            {
                Nota = avaliacao.Nota,
                Comentario = avaliacao.Comentario
            });
        }

        public void CancelarPedido(long idPedido)
        {
            this.clienteService.CancelarPedido(idPedido);
        }

        public void CriarPratoEmPedido(PratoClienteInputDto pratoCliente)
        {
            this.clienteService.CriarPratoEmPedido(pratoCliente.IdPedido, pratoCliente.IdPorcoes, new Prato
            {
                CriadoPorVendedor = pratoCliente.CriadoPorVendedor
            });
        }

        public void DesativarCartao(int idCartao)
        {
            this.clienteService.DesativarCartao(idCartao);
        }

        public void FazerPedido(PedidoInputDto pedido)
        {
            this.clienteService.FazerPedido(pedido.IdCliente, pedido.IdLoja, new Pedido
            {
                StatusPedido = StatusPedido.Iniciado
            });
        }

        public void InserirPratoNoPedido(InserirPratoInputDto inserirPrato)
        {
            this.clienteService.InserirPratoNoPedido(inserirPrato.IdPratos, inserirPrato.IdPedido, inserirPrato.Comentario);
        }

        public void RealizarPagamento(PagamentoInputDto pagamento)
        {
            this.clienteService.RealizarPagamento(pagamento.IdPedido, new Pagamento
            {
                OpcaoDePagamento = pagamento.OpcaoPagamento
            });
        }

        public IList<Prato> ListarPratosDaLoja(int idLoja)
        { 
            
            return this.clienteService.ListarPratosLoja(idLoja);
        }

        public IList<Porcao> ListarPorcoesDaLoja(int idLoja)
        {
            return this.clienteService.ListarPorcoesLoja(idLoja);
        }

        public IList<Loja> ListarLojas()
        {
            return this.clienteService.ListarTodasLojas();
        }

        public IList<Cartao> ListarCartoesCliente(long idCliente)
        {
            return this.clienteService.ListarCartoesCliente(idCliente);
        }

        public IList<Bairro> ListarBairrosLoja(int idLoja)
        {
            return this.clienteService.ListarBairrosLoja(idLoja);
        }

        public IList<Porcao> ListarPorcoesPrato(int idPrato)
        {
            return this.clienteService.ListarPorcoesPrato(idPrato);
        }
    }
}
