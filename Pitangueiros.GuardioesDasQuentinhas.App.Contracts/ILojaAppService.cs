using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.App.Entities;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Services;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.App.Contracts
{
    public interface ILojaAppService: IAppService
    {
        void AtualizarStatusDoPedido(AtualizarStatusInputDto atualizarStatus);
        void CriarNovaPorcao(PorcaoInputDto porcao);
        void CriarNovoPrato(PratoInputDto prato);
        void AdicionarBairroDeEntrega(BairroInputDto bairro);
        void ExcluirBairroDeEntrega(int idBairro);
        void ExcluirPratoDaLoja(int idPrato);
        void ExcluirPorcaoDaLoja(int idPorcao);
        IList<Prato> ListarPratosDaLoja(int idLoja);
        IList<Loja> ListarLojas();
        IList<Bairro> ListarBairrosLoja(int idLoja);
        IList<Porcao> ListarPorcoesPrato(int idPrato);
        IList<Porcao> ListarPorcoesLoja(int idLoja);
        IList<Pedido> ListarPedidosLoja(int idLoja);
        IList<string> ListarCategoriaPorcao();
    }
}
