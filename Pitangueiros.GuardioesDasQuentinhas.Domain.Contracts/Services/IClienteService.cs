using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Services
{
    public interface IClienteService 
    {
        void FazerPedido(long idCliente, Pedido pedido);
        void CancelarPedido(long idPedido);
        void AdicionarUmCartao(long idCliente, Cartao cartao);
        void RealizarPagamento(long idPedido, Pagamento pagamento);
        void AvaliarPedido(long idPedido, Avaliacao avaliacao);
    }
}
