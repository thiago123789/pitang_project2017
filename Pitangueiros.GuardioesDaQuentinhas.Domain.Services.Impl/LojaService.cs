using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Services;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Services.Impl
{
    public class LojaService : ILojaService  {
        public bool AceitarPedido(Pedido pedido) {

            bool aceito = false;

            if (pedido != null && pedido.StatusPedido.Equals(StatusPedido.Aceito))
            {
                aceito = true;
            }

            return aceito;
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
