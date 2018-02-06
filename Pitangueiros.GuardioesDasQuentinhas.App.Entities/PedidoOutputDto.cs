using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.App.Entities
{
    public class PedidoOutputDto
    { 
        public long Id { get; set; }
        public string Comentario { get; set; }
        public double Preco { get; set; }
        public StatusPedido StatusPedido { get; set; }
        //public PagamentoOutputDto Pagamento { get; set; }
        //public AvaliacaoOutputDto Avaliacao { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime UltimaModificacao { get; set; }
    }
}
