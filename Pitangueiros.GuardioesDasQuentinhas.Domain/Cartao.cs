using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Entities
{
    public class Cartao : EntidadeBase<int> {
        public int Numero { get; set; }
        public int Validade { get; set; }
        public int Bandeira { get; set; }
        public int CodSeg { get; set; }
        public int NomeTitular { get; set; }
    }
}