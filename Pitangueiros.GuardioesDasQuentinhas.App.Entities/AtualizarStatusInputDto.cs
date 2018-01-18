using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.App.Entities
{
    public class AtualizarStatusInputDto
    {
        [Required]
        [Display(Name = "Id do pedido")]
        public int IdPedido { get; set; }
        [Required]
        [Display(Name = "Status do pedido")]
        public StatusPedido Status { get; set; }

    }
}
