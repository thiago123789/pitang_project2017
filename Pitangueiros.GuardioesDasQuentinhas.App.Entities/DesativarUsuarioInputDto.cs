using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Pitangueiros.GuardioesDasQuentinhas.App.Entities
{
    public class DesativarUsuarioInputDto
    {
        [Required]
        [Display(Name = "Email")]
        public string Login { get; set; }
    }
}
