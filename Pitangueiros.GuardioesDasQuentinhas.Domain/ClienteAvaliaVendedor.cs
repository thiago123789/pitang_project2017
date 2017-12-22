namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Entities {
    public class ClienteAvaliaLoja : EntidadeBase {
        public Cliente Cliente { get; set; }
        public Avaliacao Avaliacao { get; set; }
        public Loja Loja { get; set; }
    }
}