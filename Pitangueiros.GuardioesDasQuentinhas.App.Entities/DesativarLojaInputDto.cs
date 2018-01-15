using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Pitangueiros.GuardioesDasQuentinhas.App.Contracts
{
    public class DesativarLojaInputDto
    {
        [Required]
        [Display(Name = "Nome da Loja")]
        public string Login { get; set; }
    }
}
