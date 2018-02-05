using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.App.Entities;


namespace Pitangueiros.GuardioesDasQuentinhas.App.Contracts
{
    public interface IClienteAppService : IAppService
    {

        void FazerPedido(PedidoInputDto pedido);
        void CriarPratoEmPedido(PratoClienteInputDto pratoCliente);
        void InserirPratoNoPedido(InserirPratoInputDto inserirPrato);
        void CancelarPedido(long idPedido);
        void AdicionarUmCartao(CartaoInputDto cartao);
        void DesativarCartao(int idCartao);
        void AtualizarCartao(AtualizarCartaoInputDto atualizarCartao);
        void RealizarPagamento(PagamentoInputDto pagamento);
        void AvaliarPedido(AvaliacaoInputDto avaliacao);

    }
}
