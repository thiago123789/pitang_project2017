﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pitangueiros.GuardioesDasQuentinhas.App.Entities
{
    public class VendedorOutputDto
    {
        public List<LojaOutputDto> Lojas { get; set; }
        public UsuarioOutputDto usuario { get; set; }
    }
}