using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Entities {
    public class Pagamento : EntidadeBase<long>
    {
        public OpcaoDePagamento OpcaoDePagamento { get; set; }
    }
}