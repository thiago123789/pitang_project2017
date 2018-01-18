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
        [Display(Name ="Nome da Loja")]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Endereco da Loja")]
        public string Endereco { get; set; }

        [Required]
        [Display(Name = "Bairros de entrega")]
        public IList<string> Bairros { get; set; }

        [Required]
        [Display(Name = "Id Do Vendedor")]
        public long IdVendedor { get; set; }

    }
}
