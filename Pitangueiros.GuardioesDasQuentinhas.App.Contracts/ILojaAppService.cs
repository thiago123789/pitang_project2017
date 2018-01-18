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
        void CriarNovaPorcao(int idLoja, PorcaoInputDto porcaoInput);
        void CriarNovoPrato(int idLoja, PratoInputDto pratoInput);
        /*
        void DefinirAreaDeEntrega(DefinirAreaDeEntregaDto areas)
        {
           this.lojaService.DefinirAreaDeEntrega(areas.idLoja,areas.Bairros);
        }
        */
        void ExcluirPratoDaLoja(int id);
    }
}
