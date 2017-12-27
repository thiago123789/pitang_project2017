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
        //Nesse metodo ele poderá adicinar observação definindo modificações no pedido
        void FazerPedido(Pedido pedido);
        void CancelarPedido(Pedido pedido);
        //Precisa ser criada uma nova entidade para armazenar a forma de pagamento de cada usuário (Numero do cartao, Bandeira)
        void AdicionarUmCartao(Cartao cartao);
        //Após feita a compra ele poderá avaliar baseado na qualidade do serviço
        void FazerAvaliacaoEmPedido(Pedido pedido, Comentario comentario);
        void RealizarPagamento(Pedido pedido, Pagamento pagamento);
        void AvaliarLoja(Loja loja, Avaliacao avaliacao);
       
    }
}
