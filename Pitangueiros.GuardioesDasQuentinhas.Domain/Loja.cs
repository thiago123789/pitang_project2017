using System;
using System.Collections.Generic;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Entities {
    public class Loja : EntidadeBase<int>, IDeleteLogico, IAuditoria {
        public string Nome { get; set; }
        public string EnderecoDaLoja { get; set; }
        public Usuario Vendedor { get; set; }
        public virtual IList<Prato> Pratos { get; set; }
        public virtual IList<Bairro> Bairros { get; set; }
        public virtual IList<Pedido> Pedidos { get; set; }
        public virtual IList<Porcao> Porcoes { get; set; }
        public bool IsDeleted { get; set; }
        public double MediaAvaliacoes { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime UltimaModificacao { get; set; }

        public Loja()
        {
            this.Porcoes = new List<Porcao>();
            this.Pratos = new List<Prato>();
            this.Pedidos = new List<Pedido>();
            this.Bairros = new List<Bairro>();
            //this.Vendedor = new Usuario();
        }
    }
}