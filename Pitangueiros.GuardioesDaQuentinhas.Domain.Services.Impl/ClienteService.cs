using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Services;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Services.Impl
{
    class ClienteService : IClienteService
    {
        public void AdicionarUmCartao(Cartao cartao)
        {
            throw new NotImplementedException();
        }

        public void AvaliarLoja(Loja loja, Avaliacao avaliacao)
        {
            throw new NotImplementedException();
        }

        public void CancelarPedido(Pedido pedido)
        {
            throw new NotImplementedException();
        }

        public void FazerAvaliacaoEmPedido(Pedido pedido, Comentario comentario)
        {
            throw new NotImplementedException();
        }

        public void FazerPedido(Pedido pedido)
        {
            throw new NotImplementedException();
        }

        public void RealizarPagamento(Pedido pedido, Pagamento pagamento)
        {
            throw new NotImplementedException();
        }
    }
}
