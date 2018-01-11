using System.ComponentModel.DataAnnotations;

namespace Pitangueiros.GuardioesDasQuentinhas.App.Entities
{
    public class PorcoesInputDto
    {
        [Required]
        [Display(Name = "Item")]
        public string Item { get; set; }
        [Required]
        [Display(Name = "Quantidade")]
        public int Quantidade { get; set; }
        [Required]
        [Display(Name = "Preço")]
        public int Preco { get; set; }
        [Required]
        [Display(Name = "Categoria")]
        public string Categoria { get; set;}
    }
}