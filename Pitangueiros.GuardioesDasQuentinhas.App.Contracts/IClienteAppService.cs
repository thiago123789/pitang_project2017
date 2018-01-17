using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.App.Entities;


namespace Pitangueiros.GuardioesDasQuentinhas.App.Contracts
{
    public interface IClienteAppService : IApplicationService
    {
        //void EscolherLoja(LojaInputDto loja);
        //void EscolherPrato();
        //void PersonalizarPrato();
        void FazerPedido(PedidoInputDto pedido);
        void CancelarPedido(CancelarPedidoInputDto id);
        void AdicionarUmCartao(CartaoInputDto cartao);
        void FazerComentarioEmPedido(ComentarioInputDto comentario);
        void RealizarPagamento(PagamentoInputDto pagamento);
        void AvaliarPedido(AvaliacaoInputDto avaliacao);

    }
}
