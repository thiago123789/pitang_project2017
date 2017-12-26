﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Entities {
    public class Porcao : EntidadeBase {
        public string Item { get; set; }

        public int Quantidade { get; set; }

        public int Preco
        {
            get => default(int);
            set
            {
            }
        }
    }
}