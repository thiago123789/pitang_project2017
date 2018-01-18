using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Pitangueiros.GuardioesDasQuentinhas.App.Entities
{
    public class CartaoInputDto
    {
        [Required]
        [Display(Name = "Id do Cliente")]
        public long IdCliente { get; set; }
        [Required]
        [Display(Name = "Nome do Titular")]
        public string NomeTitular { get; set; }

        [Required]
        [Display(Name = "Número do Cartão")]
        public string Numero { get; set; }

        [Required]
        [Display(Name = "Bandeira")]
        public string Bandeira { get; set; }

        [Required]
        [Display(Name = "Código de Segurança")]
        public string CodSeg { get; set; }

        [Required]
        [Display(Name = "Validade")]
        public string Validade { get; set; }
    }
}
