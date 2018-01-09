using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Entities {
    public class Cliente : Usuario {
        
        public List<Cartao> Cartao { get; set; }

        public List<Pedido> Pedido { get; set; }
    }
}