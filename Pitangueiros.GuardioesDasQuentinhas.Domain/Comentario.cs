using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Entities {
    public class Comentario : EntidadeBase<long> {
        public string Texto { get; set; }
    }
}