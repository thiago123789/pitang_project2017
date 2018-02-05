using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Entities {
    public class Pagamento : EntidadeBase<long>, IDeleteLogico
    {
        public Pedido Pedido { get; set; }
        public OpcaoDePagamento OpcaoDePagamento { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime UltimaModificacao { get; set; }
        public bool IsDeleted { get; set; }
    }
}