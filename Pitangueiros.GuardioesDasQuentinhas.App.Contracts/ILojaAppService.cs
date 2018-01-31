using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.App.Entities;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Services;

namespace Pitangueiros.GuardioesDasQuentinhas.App.Contracts
{
    public interface ILojaAppService: IAppService
    {
        void AtualizarStatusDoPedido(AtualizarStatusInputDto atualizarStatus);
        void CriarNovaPorcao(PorcaoInputDto porcao);
        void CriarNovoPrato(PratoInputDto prato);
        void AdicionarBairroDeEntrega(int idLoja, string bairro);
        void ExcluirBairroDeEntrega(int idLoja, string bairro);
        void ExcluirPratoDaLoja(int idPrato);
    }
}
