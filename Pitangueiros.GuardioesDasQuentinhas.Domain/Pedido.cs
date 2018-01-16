using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Entities {
    public class Pedido : EntidadeBase<long>,IDeleteLogico {
        public IList<Prato> Pratos { get; set; }
        public Loja Loja { get; set; }
        public string Comentario { get; set; }
        public double Preco { get; set; }
        public StatusPedido StatusPedido { get; set; }
        public Cliente Cliente { get; set; }
        public Pagamento Pagamento { get; set; }
        public bool IsDeleted { get; set; }
    }
}