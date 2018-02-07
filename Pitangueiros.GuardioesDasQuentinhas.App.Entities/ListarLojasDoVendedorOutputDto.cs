using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pitangueiros.GuardioesDasQuentinhas.App.Entities
{
    public class ListarLojasDoVendedorOutputDto
    {
        public long IdVendedor { get; set; }
        public IList<LojaOutputDto> Lojas { get; set; }
    }
}
