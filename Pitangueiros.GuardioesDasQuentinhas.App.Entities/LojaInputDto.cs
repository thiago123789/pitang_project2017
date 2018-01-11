using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Pitangueiros.GuardioesDasQuentinhas.App.Entities
{
    public class LojaInputDto
    {
        [Required]
        [Display(Name = "Nome da loja")]
        public string Nome { get; set; }
        [Required]
        [Display(Name = "Cep da Loja")]
        public string Cep { get; set; }
        [Required]
        [Display(Name = "Vendedor")]
        public VendedorInputDto Vendedor { get; set; }
        /*[Required]
        [Display(Name = "Pratos")]
        public List<PratoInputDto> Pratos { get; set; }
        */
        [Required]
        [Display(Name = "Ceps")]
        public List<string> Ceps { get; set; }
        /*
        [Required]
        [Display(Name = "Pedidos")]
        public List<PedidoInputDto> Pedidos { get; set; }
        */

    }
}
