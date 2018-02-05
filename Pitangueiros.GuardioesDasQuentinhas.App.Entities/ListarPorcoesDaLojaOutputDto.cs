using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.App.Entities
{
    public class ListarPorcoesDaLojaOutputDto
    {
        public int idLoja { get; set; }
        public IList<Porcao> Porcoes{ get; set; }
    }
}
