using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Pitangueiros.GuardioesDasQuentinhas.App.Entities
{
    public class LojaInputDto
    {
        [Required]
        [Display(Name ="Lojas")]
        public IList Lojas { get; set; }

        [Required]
        [Display(Name = "CEP da Loja")]
        public string CEP { get; set; }

        [Required]
        [Display(Name = "Area de entrega")]
        public IList CEPs { get; set; }
    }
}
