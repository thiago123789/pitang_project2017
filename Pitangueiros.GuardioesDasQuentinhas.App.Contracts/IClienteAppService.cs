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

        void IniciarPedido(PedidoInputDto pedido);
        void CancelarPedido(long idPedido);
        void AdicionarUmCartao(CartaoInputDto cartao);
        void RealizarPagamento(PagamentoInputDto pagamento);
        void AvaliarPedido(AvaliacaoInputDto avaliacao);

    }
}
