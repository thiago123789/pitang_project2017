using System.Collections.Generic;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Entities {
    public class Loja : EntidadeBase<int> { 
        public List<Prato> Prato { get; set; }
        public List<string> Ceps { get; set; }
    }
}