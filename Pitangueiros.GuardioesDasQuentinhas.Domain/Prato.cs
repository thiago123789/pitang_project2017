using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Entities {
    public class Prato : EntidadeBase {
        public List<Porcao> Porcao
        {
            get => default(Porcao);
            set
            {
            }
        }
    }
}