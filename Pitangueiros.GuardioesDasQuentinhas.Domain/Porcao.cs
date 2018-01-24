﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Entities {
    public class Porcao : EntidadeBase<long>, IDeleteLogico, IAuditoria{
        public string Item { get; set; }
        public int Quantidade { get; set; }
        public int Preco { get; set; }
        public CategoriaPorcao CategoriaPorcao { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime UltimaModificacao { get; set; }
    }
}