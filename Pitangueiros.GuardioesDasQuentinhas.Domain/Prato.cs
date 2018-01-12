using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Entities {
    public class Prato : EntidadeBase<int> {
        public IList<Porcao> Porcao { get; set; }
        public double Preco { get; set; }
    }
}