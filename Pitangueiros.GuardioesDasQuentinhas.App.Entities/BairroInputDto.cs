using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Pitangueiros.GuardioesDasQuentinhas.App.Entities
{
    public class BairroInputDto
    {
        [Required]
        [Display(Name = "Nome do Bairro")]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Id Do Loja")]
        public int IdLoja { get; set; }
    }
}
