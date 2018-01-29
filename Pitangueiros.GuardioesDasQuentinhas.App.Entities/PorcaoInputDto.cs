using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.App.Entities
{
    public class PorcaoInputDto
    {
        [Required]
        [Display(Name = "Item")]
        public string Item { get; set; }
        [Required]
        [Display(Name = "Quantidade")]
        public int Quantidade { get; set; }
        [Required]
        [Display(Name = "Preço")]
        public int Preco { get; set; }
        [Required]
        [Display(Name = "Categoria")]
        public CategoriaPorcao Categoria { get; set; }
        [Required]
        [Display(Name = "Id Da Loja")]
        public int IdLoja { get; set; }
    }
}
