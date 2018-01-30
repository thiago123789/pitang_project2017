using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.App.Entities
{
    public class PratoInputDto
    {
        [Required]
        [Display(Name = "Lista de Porcoes")]
        public IList<long> IdPorcoes { get; set; }
        [Required]
        [Display(Name = "Preco")]
        public int Preco { get; set; }
        [Required]
        [Display(Name = "Id Loja")]
        public int IdLoja { get; set; }
    }
}
