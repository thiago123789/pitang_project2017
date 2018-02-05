using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pitangueiros.GuardioesDasQuentinhas.App.Entities
{
    public class CartaoOutputDto
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public string Validade { get; set; }
        public string Bandeira { get; set; }
        public string CodSeg { get; set; }
        public string NomeTitular { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime UltimaModificacao { get; set; }
    }
}
