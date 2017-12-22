using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Entities {
    public class Pedido : EntidadeBase {
        public List<Prato> Prato { get; set; }

        public Comentario Comentario { get; set; }

        public double Preco { get; set; }

        public Local LocalDeEntrega
        {
            get => default(Local);
            set
            {
            }
        }
    }
}