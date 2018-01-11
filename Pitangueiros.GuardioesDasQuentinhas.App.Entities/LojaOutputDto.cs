using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pitangueiros.GuardioesDasQuentinhas.App.Entities
{
    public class LojaOutputDto
    {


        public string Nome { get; set; }

        public string Cep { get; set; }

        public VendedorInputDto Vendedor { get; set; }
        /*
        public List<PratoInputDto> Pratos { get; set; }
        */

        public List<string> Ceps { get; set; }

        //public List<PedidoInputDto> Pedidos { get; set; }

    }
}
