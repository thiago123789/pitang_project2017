﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pitangueiros.GuardioesDasQuentinhas.App.Entities
{
    public class ListarPorcoesDaLojaOutputDto
    {
        public int IdLoja { get; set; }
        public IList<PorcaoOutputDto> Porcoes{ get; set; }
    }
}