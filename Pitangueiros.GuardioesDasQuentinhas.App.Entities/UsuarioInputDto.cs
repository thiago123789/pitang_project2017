using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Pitangueiros.GuardioesDasQuentinhas.App.Entities
{
    public class UsuarioInputDto
    {
        [Required]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Senha")]
        public string Senha { get; set; }

        [Required]
        [Compare(nameof(Senha), ErrorMessage = "A senha e a confirmação são diferentes.")]
        [Display(Name = "Confirmação de Senha")]
        public string ConfirmacaoSenha { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "E-mail inválido!")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

    }
}
