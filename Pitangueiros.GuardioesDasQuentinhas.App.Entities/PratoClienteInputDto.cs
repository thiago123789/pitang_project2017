using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Pitangueiros.GuardioesDasQuentinhas.App.Entities
{
    public class PratoClienteInputDto
    {
        [Required]
        [Display(Name = "Lista de Porcoes")]
        public IList<long> IdPorcoes { get; set; }

        [Required]
        [Display(Name = "Id do Pedido")]
        public long IdPedido { get; set; }

        [Required]
        [Display(Name = "Criado Por Vendedor")]
        public bool CriadoPorVendedor { get; set; }
    }
}
