using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace Pitangueiros.GuardioesDasQuentinhas.App.Entities
{
    public class ComentarioInputDto
    {
        [Required]
        [Display(Name = "Comentario")]
        public string Comentario { get; set; }

        [Required]
        [Display(Name = "Pedido")]
        public Pedido Pedido { get; set; }
    }
}
