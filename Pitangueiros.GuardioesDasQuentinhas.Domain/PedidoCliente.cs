using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Entities {
    public class PedidoCliente : EntidadeBase {
        public Cliente Cliente { get; set; }

        public Pedido Pedido { get; set; }

        public Pagamento Pagamento { get; set; }

        public PedidoCliente PedidoCliente1
        {
            get => default(PedidoCliente);
            set
            {
            }
        }
    }
}