using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.App.Entities
{
    public class ListarPratosDaLojaOutputDto
    {
        public int IdLoja { get; set; }
        public IList<Prato> Pratos { get; set; }
    }
}
