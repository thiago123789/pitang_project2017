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
        public string Nome { get; set; }

        [Display(Name = "Endereco da Loja")]
        public string Endereco { get; set; }

        [Display(Name = "Bairros de entrega")]
        public IList<string> Bairros { get; set; }
    }
}
