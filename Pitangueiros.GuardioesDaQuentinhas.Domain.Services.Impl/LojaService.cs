using System;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Services;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Repositories;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Services.Impl
{
    public class LojaService : ILojaService  {

        private IPedidoRepository pedidoRepository;

        public bool AceitarPedido(Pedido pedido) { 
            if (pedido != null)
            {
                pedido.StatusPedido = StatusPedido.Aceito;

            }
            return true;
        }

        public void AtualizarStatusDoPedido(Pedido pedido) {
           
        }

        public void CriarNovoPrato(Prato prato) {
            throw new NotImplementedException();
        }

        public void DefinirAreaDeEntrega(string cep) {
            throw new NotImplementedException();
        }

        public void ExcluirPratoDaLoja(Prato prato) {
            throw new NotImplementedException();
        }
    }
}
