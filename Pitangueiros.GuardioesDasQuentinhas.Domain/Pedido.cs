using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Entities {
    public class Pedido : EntidadeBase<long>, IDeleteLogico, IAuditoria {
        public virtual IList<Prato> Pratos { get; set; }
        public Loja Loja { get; set; }
        public string Comentario { get; set; }
        public double Preco { get; set; }
        public StatusPedido StatusPedido { get; set; }
        public Usuario Cliente { get; set; }
        public Pagamento Pagamento { get; set; }
        public Avaliacao Avaliacao { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime UltimaModificacao { get; set; }

        public Pedido()
        {
            this.Pratos = new List<Prato>();
            this.Loja = new Loja();
        }
    }
}