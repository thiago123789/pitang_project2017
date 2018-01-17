using System;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Entities
{
    public class Avaliacao : EntidadeBase<int>, IDeleteLogico
    {
        //public Cliente Cliente { get; set; }
        public string Comentario { get; set; }
        //public Loja Loja { get; set; }
        public DateTime DataAvaliacao { get; set; }
        public int Nota { get; set; }
        public bool IsDeleted { get ; set; }
    }
}