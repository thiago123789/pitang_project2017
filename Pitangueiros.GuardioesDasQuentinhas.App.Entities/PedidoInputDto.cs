using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.App.Entities
{
    public class PedidoInputDto
    {
        [Required]
        [Display(Name = "Loja")]
        public Loja Loja { get; set; }

        [Required]
        [Display(Name = "Pratos")]
        public IList<Prato> Pratos { get; set; }

    }
}
