using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.App.Entities
{
    public class PagamentoInputDto
    {
        [Required]
        [Display(Name = "Id do Pedido")]
        public long IdPedido { get; set; }

        [Required]
        [Display(Name = "Opção de pagamento")]
        public OpcaoDePagamento OpcaoPagamento { get; set; }
    }
}
