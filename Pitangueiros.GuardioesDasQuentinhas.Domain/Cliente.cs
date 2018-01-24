using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Entities {
    public class Cliente : Usuario {
        public IList<Cartao> Cartao { get; set; }
        public IList<Pedido> Pedido { get; set; }
    }
}