using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pitangueiros.GuardioesDasQuentinhas.App.Entities
{
    public class LojaOutputDto
    {  
        public int Id { get; set; }
        public string Nome { get; set; }
        public string EnderecoDaLoja { get; set; }
        public double MediaAvaliacoes { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime UltimaModificacao { get; set; }
    }
}
