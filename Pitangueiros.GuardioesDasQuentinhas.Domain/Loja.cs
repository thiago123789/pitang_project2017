using System;
using System.Collections.Generic;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Entities {
    public class Loja : EntidadeBase<int>, IDeleteLogico, IAuditoria {
        public string Nome { get; set; }
        public string EnderecoDaLoja { get; set; }
        public Usuario Vendedor { get; set; }
        public IList<Prato> Pratos { get; set; }
        public IList<string> BairrosDeEntrega { get; set; }
        public IList<Pedido> Pedidos { get; set; }
        public IList<Porcao> Porcoes { get; set; }
        public bool IsDeleted { get; set; }
        public double MediaAvaliacoes { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime UltimaModificacao { get; set; }
    }
}