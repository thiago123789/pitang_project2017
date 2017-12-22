using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Entities {
    public class Usuario : EntidadeBase {
        public string Nome { get; set; }

        public string Senha { get; set; }

        public string Email { get; set; }
    }
}