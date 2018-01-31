using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Pitangueiros.GuardioesDasQuentinhas.App.Entities
{
    public class AtualizarLojaInputDto
    {
        [Required]
        [Display(Name = "Id da Loja")]
        public int IdLoja { get; set; }

        [Display(Name = "Nome da Loja")]
        [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "[Null]")]
        public string Nome { get; set; }

        [Display(Name = "Endereco da Loja")]
        [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "[Null]")]
        public string Endereco { get; set; }
    }
}
