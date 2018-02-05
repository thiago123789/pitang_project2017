using System;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Entities
{
    public class Avaliacao : EntidadeBase<int>, IDeleteLogico 
    {
        public string Comentario { get; set; }
        public Pedido Pedido { get; set; }
        public DateTime DataAvaliacao { get; set; }
        public int Nota { get; set; }
        public bool IsDeleted { get ; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime UltimaModificacao { get; set; }
    }
}