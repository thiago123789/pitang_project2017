using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Entities {
    public class Vendedor : Usuario, IDeleteLogico {
        public IList<Loja> Lojas { get; set; }
    }
}