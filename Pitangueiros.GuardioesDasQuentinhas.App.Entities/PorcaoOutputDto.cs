using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pitangueiros.GuardioesDasQuentinhas.App.Entities
{
    public class PorcaoOutputDto
    {
        public string Item { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public CategoriaPorcao CategoriaPorcao { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime UltimaModificacao { get; set; }
        public long Id { get; set; }
    }
}
