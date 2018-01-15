﻿using System.Collections.Generic;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Entities {
    public class Loja : EntidadeBase<int>, IDeleteLogico {
        public string Nome { get; set; }
        public string CEPDaLoja { get; set; }
        public Vendedor Vendedor { get; set; }
        public IList<Prato> Prato { get; set; }
        public IList<string> CEPsDeEntrega { get; set; }
        public IList<Pedido> Pedido { get; set; }
        public bool IsDeleted { get; set; }
    }
}