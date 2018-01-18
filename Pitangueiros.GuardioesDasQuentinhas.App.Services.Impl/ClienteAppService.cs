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

        public void FazerPedido(PedidoInputDto pedido)
        {
            this.clienteService.FazerPedido(pedido.IdCliente, new Pedido
            {
                Loja = pedido.Loja,
                Pratos = pedido.Pratos,
                Comentario = pedido.Comentario
            });
        }

        public void RealizarPagamento(PagamentoInputDto pagamento)
        {
            throw new NotImplementedException();
        }
    }
}
