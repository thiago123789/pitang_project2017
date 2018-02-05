using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Pitangueiros.GuardioesDasQuentinhas.App.Entities
{
    public class AtualizarCartaoInputDto
    {
        [Required]
        [Display(Name = "Id do Cartao")]
        public int IdCartao { get; set; }

        [Display(Name = "Nome do Titular")]
        [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "[Null]")]
        public string NomeTitular { get; set; }

        [Display(Name = "Número do Cartão")]
        [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "[Null]")]
        public string Numero { get; set; }

        [Display(Name = "Bandeira")]
        [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "[Null]")]
        public string Bandeira { get; set; }

        [Display(Name = "Código de Segurança")]
        [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "[Null]")]
        public string CodSeg { get; set; }

        [Display(Name = "Validade")]
        [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "[Null]")]
        public string Validade { get; set; }
    }
}
