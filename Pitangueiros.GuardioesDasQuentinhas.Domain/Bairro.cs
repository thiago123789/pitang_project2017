using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Entities
{
    public class Bairro : EntidadeBase<int>, IDeleteLogico, IAuditoria
    {
        public bool IsDeleted { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime UltimaModificacao { get; set; }
        public Loja Loja { get; set; }
        public string Nome { get; set; }
    }
}
