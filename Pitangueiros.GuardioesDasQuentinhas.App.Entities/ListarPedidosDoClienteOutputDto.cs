using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pitangueiros.GuardioesDasQuentinhas.App.Entities
{
    public class ListarPedidosDoClienteOutputDto
    {
        public long IdCliente { get; set; }
        public IList<PedidoOutputDto> Pedidos { get; set; }
    }
}
