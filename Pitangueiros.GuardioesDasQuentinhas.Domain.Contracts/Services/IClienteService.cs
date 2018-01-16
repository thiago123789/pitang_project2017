using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Services
{
    public interface IClienteService 
    {
        void FazerPedido(Pedido pedido);
        //void EscolherLoja(Loja loja);
        //void EscolherPrato(Prato prato);
        //void PersonalizarPrato(Prato prato);
        void CancelarPedido(long id);
        //Precisa ser criada uma nova entidade para armazenar a forma de pagamento de cada usuário (Numero do cartao, Bandeira)
        void AdicionarUmCartao(Cartao cartao);
        //Após feita a compra ele poderá avaliar baseado na qualidade do serviço
        void FazerComentarioEmPedido(Pedido pedido, string comentario);
        void RealizarPagamento(Pedido pedido, Pagamento pagamento);
        void AvaliarLoja(Loja loja, Avaliacao avaliacao);
    }
}
