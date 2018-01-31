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
        void CadastrarBairro(BairroInputDto bairro);
        void AdicionarBairroDeEntrega(int idLoja, int idbairro);
        void ExcluirBairroDeEntrega(int idLoja, int idbairro);
        void ExcluirPratoDaLoja(int idPrato);
    }
}
