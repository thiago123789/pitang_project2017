﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pitangueiros.GuardioesDasQuentinhas.App.Entities
{
    public class ListarCartoesDoClienteOutputDto
    {
        public long IdCliente { get; set; }
        public IList<CartaoOutputDto> Cartoes { get; set; }
    }
}
