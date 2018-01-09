using System.Collections.Generic;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Entities {
    public class Loja : EntidadeBase<int> {
        public string Nome { get; set; }
        public string CEP { get; set; }
        public Vendedor Vendedor { get; set; }
        public List<Prato> Prato { get; set; }
        public List<string> CEPs { get; set; }
        public List<Pedido> Pedido { get; set; }
    }
}