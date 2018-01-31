using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Pitangueiros.GuardioesDasQuentinhas.App.Entities
{
    public class PratoPedidoInputDto
    {
        [Required]
        [Display(Name = "Porcoes")]
        public IList<int> IdPratos { get; set; }

        [Display(Name = "Comentario")]
        public string Comentario { get; set; }
    }
}
