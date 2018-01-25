using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Entities {
    public class Usuario : EntidadeBase<long>, IDeleteLogico, IAuditoria {
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime UltimaModificacao { get; set; }
        public IList<Permissao> Permissoes { get; set; }
        public IList<Cartao> Cartao { get; set; }
        public IList<Pedido> Pedido { get; set; }
        public IList<Loja> Lojas { get; set; }
    }

}