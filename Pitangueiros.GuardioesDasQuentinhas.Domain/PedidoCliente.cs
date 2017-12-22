using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Entities {
    public class PedidoCliente : EntidadeBase {
        public Cliente Cliente
        {
            get => default(Cliente);
            set
            {
            }
        }

        public Pedido Pedido
        {
            get => default(Pedido);
            set
            {
            }
        }

        public Pagamento Pagamento
        {
            get => default(Pagamento);
            set
            {
            }
        }
    }
}