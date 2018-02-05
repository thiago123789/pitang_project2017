using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Pitangueiros.GuardioesDasQuentinhas.App.Entities
{
    public class InserirPratoInputDto
    {
        [Required]
        [Display(Name = "Lista de Pratos")]
        public IList<int> IdPratos { get; set; }

        [Required]
        [Display(Name = "Id do Pedido")]
        public long IdPedido { get; set; }

        [Display(Name = "Comentário")]
        [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "[Null]")]
        public string Comentario { get; set; }
    }
}
