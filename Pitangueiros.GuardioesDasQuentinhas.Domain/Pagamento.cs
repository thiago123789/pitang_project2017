using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Entities {
    public class Pagamento : EntidadeBase {
        public FormasDePagamento FormasDePagamento
        {
            get => default(FormasDePagamento);
            set
            {
            }
        }

        public int NumeroCartao
        {
            get => default(int);
            set
            {
            }
        }
    }
}