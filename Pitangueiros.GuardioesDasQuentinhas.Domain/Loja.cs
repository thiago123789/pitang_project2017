using System.Collections.Generic;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Entities {
    public class Loja : EntidadeBase<int> {
        public string Nome { get; set; }
        public string CEP { get; set; }
        public Vendedor Vendedor { get; set; }
        public IList<Prato> Prato { get; set; }
        public IList<string> CEPs { get; set; }
        public IList<Pedido> Pedido { get; set; }
    }
}