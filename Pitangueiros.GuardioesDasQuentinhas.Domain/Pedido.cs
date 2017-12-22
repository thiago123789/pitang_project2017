using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Entities {
    public class Pedido : EntidadeBase {
        public List<Prato> Prato
        {
            get => default(Prato);
            set
            {
            }
        }

        public Comentario Comentario
        {
            get => default(Comentario);
            set
            {
            }
        }

        public double Preco
        {
            get => default(int);
            set
            {
            }
        }
    }
}