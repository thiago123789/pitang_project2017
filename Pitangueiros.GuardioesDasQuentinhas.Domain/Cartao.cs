using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Entities
{
    public class Cartao : EntidadeBase<int>, IDeleteLogico {
        public string Numero { get; set; }
        public string Validade { get; set; }
        public string Bandeira { get; set; }
        public string CodSeg { get; set; }
        public string NomeTitular { get; set; }
        public Cliente Cliente { get; set; }
        public bool IsDeleted { get; set; }
    }
}