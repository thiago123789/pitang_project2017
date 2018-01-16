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
        void EscolherLoja(LojaInputDto loja);
        void EscolherPrato();
        void PersonalizarPrato();
        void FazerPedido(FazerPedidoInputDto fazerPedido);
        void CancelarPedido(CancelarPedidoInputDto cancelarPedido);
        void AdicionarUmCartao(CartaoInputDto cartaoInput);
        void FazerComentarioEmPedido(FazerComentarioInputDto comentario);
        void RealizarPagamento(RealizarPagamentoInputDto pagar);
        void AvaliarLoja(AvaliarLojaInputDto avaliacao);

    }
}
