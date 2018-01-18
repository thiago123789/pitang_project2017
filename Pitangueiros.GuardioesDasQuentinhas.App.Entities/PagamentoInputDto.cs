using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Pitangueiros.GuardioesDasQuentinhas.App.Entities
{
    public class PagamentoInputDto
    {
        [Required]
        [Display(Name = "Id do Pedido")]
        public long IdPedido { get; set; }
    }
}
