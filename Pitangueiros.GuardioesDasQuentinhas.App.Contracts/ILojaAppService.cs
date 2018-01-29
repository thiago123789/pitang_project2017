using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.App.Entities;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Services;

namespace Pitangueiros.GuardioesDasQuentinhas.App.Contracts
{
    public interface ILojaAppService
    {
        void AtualizarStatusDoPedido(AtualizarStatusInputDto atualizar);
        void CriarNovaPorcao(PorcaoInputDto porcaoInput);
        void CriarNovoPrato(PratoInputDto pratoInput);
        void ExcluirPratoDaLoja(int id);
    }
}
