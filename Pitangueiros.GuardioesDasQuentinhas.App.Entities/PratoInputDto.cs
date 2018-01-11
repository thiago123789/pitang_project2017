using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Pitangueiros.GuardioesDasQuentinhas.App.Entities
{
    public class PratoInputDto
    {
        [Required]
        [Display(Name = "Porcoes")]
        public List<PorcoesInputDto> Porcoes { get; set; }
    }
}
