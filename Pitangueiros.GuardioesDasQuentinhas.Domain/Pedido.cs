using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Entities {
    public class Pedido : EntidadeBase<long> {
        public List<Prato> Prato { get; set; }
        public Comentario Comentario { get; set; }
        public double Preco { get; set; }
        public StatusPedido StatusPedido { get; set; }
        public Cliente Cliente { get; set; }
        public Pagamento Pagamento { get; set; }
    }
}