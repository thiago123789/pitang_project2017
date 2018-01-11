using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Pitangueiros.GuardioesDasQuentinhas.App.Entities
{
    public class VendedorInputDto
    {
        [Required]
        public UsuarioInputDto Usuario { get; set; }

        [Required]
        [Display(Name = "Suas Lojas")] 
        public List<LojaInputDto> Lojas { get; set; }
    }
}
