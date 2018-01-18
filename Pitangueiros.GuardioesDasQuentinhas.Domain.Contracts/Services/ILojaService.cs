using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Services
{
    public interface ILojaService { 
        void CriarNovoPrato(Prato prato, int lojaId);
        void CriarNovaPorcao(int idLoja, Porcao porcao);
        void ExcluirPratoDaLoja(int id);
        void AdicionarBairroDeEntrega(string nomeLoja, string bairro);
        void ExcluirBairroDeEntrega(string nomeLoja, string bairro);
        void AtualizarStatusDoPedido(long idPedido, StatusPedido status);
    }
}
