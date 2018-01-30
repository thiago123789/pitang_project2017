using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Cross.IoC.Contracts;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Services
{
    public interface ILojaService : IDependenciaTransient
    { 
        void CriarNovoPrato(int idLoja, IList<long> idPorcoes, Prato prato);
        void CriarNovaPorcao(int idLoja, Porcao porcao);
        void ExcluirPratoDaLoja(int idLoja);
        void AdicionarBairroDeEntrega(string nomeLoja, string bairro);
        void ExcluirBairroDeEntrega(string nomeLoja, string bairro);
        void AtualizarStatusDoPedido(long idPedido, StatusPedido status);
    }
}
