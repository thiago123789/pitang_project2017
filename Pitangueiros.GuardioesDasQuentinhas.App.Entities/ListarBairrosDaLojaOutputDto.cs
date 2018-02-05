using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pitangueiros.GuardioesDasQuentinhas.App.Entities
{
    public class ListarBairrosDaLojaOutputDto
    {
        public int IdLoja { get; set; }
        public IList<BairroOutputDto> Bairros { get; set; }
    }
}
