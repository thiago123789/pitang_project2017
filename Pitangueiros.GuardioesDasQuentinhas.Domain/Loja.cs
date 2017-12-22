using System.Collections.Generic;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Entities {
    public class Loja : EntidadeBase { 
        public List<Prato> Prato { get; set; }
    }
}