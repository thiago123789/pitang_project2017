using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Entities {
    public class Prato : EntidadeBase<int>, IDeleteLogico {
        public virtual IList<Porcao> Porcoes { get; set; }
        public double Preco { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime UltimaModificacao { get; set; }
        public Loja Loja { get; set; }
        public bool CriadoPorVendedor { get; set;}
        public IList<Pedido> Pedidos { get; set; }
        public Prato()
        {
            this.Porcoes = new List<Porcao>();
            this.Pedidos = new List<Pedido>();
        }
    }
}