﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pitangueiros.GuardioesDasQuentinhas.App.Entities
{
    public class ListarPedidosDaLojaOutputDto
    {
        public int IdLoja { get; set; }
        public IList<PedidoOutputDto> Pedidos { get; set; }
    }
}
