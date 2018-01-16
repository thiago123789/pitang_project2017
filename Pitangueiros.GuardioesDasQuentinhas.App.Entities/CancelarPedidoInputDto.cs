using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Pitangueiros.GuardioesDasQuentinhas.App.Entities
{
    public class CancelarPedidoInputDto
    {
        [Required]
        [Display(Name = "Id do Pedido")]
        public long Id { get; set; }
    }
}
