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
        public IList<Porcao> Porcoes { get; set; }
        [Required]
        [Display(Name = "Categoria")]
        public int Preco { get; set; }
    }
}
