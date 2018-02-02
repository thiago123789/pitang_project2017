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
        [Display(Name = "Id do Cliente")]
        public long IdCliente { get; set; }

        //[Required]
        //[Display(Name = "Id dos Pratos")]
        //public IList<int> IdPratos { get; set; }

        //[Display(Name = "Comentario")]
        //[DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "[Null]")]
        //public string Comentario { get; set; }

        [Required]
        [Display(Name = "Id da Loja")]
        public int IdLoja { get; set; }
    }
}
