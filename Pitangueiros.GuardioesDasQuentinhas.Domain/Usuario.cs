using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Entities {
    public class Usuario : EntidadeBase<long>, IDeleteLogico {
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime UltimaModificacao { get; set; }
        public virtual IList<Permissao> Permissoes { get; set; }
        public virtual IList<Cartao> Cartao { get; set; }
        public virtual IList<Pedido> Pedidos { get; set; }
        public virtual IList<Loja> Lojas { get; set; }

        public Usuario()
        {
            this.Lojas = new List<Loja>();
            this.Pedidos = new List<Pedido>();
            this.Cartao = new List<Cartao>();
            this.Permissoes = new List<Permissao>();

        }
    }

}