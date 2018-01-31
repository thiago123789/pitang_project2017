using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.App.Contracts;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Services;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;
using Pitangueiros.GuardioesDasQuentinhas.App.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.App.Services.Impl
{
    public class LojaAppService : ILojaAppService
    {
        private readonly ILojaService lojaService;

        public LojaAppService(ILojaService lojaService)
        {
            this.lojaService = lojaService;
        }

        public void AtualizarStatusDoPedido(AtualizarStatusInputDto atualizarStatus)
        {
            this.lojaService.AtualizarStatusDoPedido(atualizarStatus.IdPedido, atualizarStatus.Status);
        }

        public void CriarNovaPorcao(PorcaoInputDto porcao)
        {
            this.lojaService.CriarNovaPorcao(porcao.IdLoja, new Porcao
            {
                Item = porcao.Item,
                Preco = porcao.Preco,
                Quantidade = porcao.Quantidade,
                CategoriaPorcao = porcao.Categoria,
            });
        }

        public void CriarNovoPrato(PratoInputDto prato)
        {

            this.lojaService.CriarNovoPrato(prato.IdLoja, prato.IdPorcoes, new Prato
            {
                Preco = prato.Preco,
                CriadoPorVendedor = prato.CriadoPorVendedor
            });
        }
       
        public void AdicionarBairroDeEntrega(int idLoja, string bairro)
        {
           this.lojaService.AdicionarBairroDeEntrega(idLoja, bairro);
        }

        public void ExcluirBairroDeEntrega(int idLoja, string bairro)
        {
            this.lojaService.ExcluirBairroDeEntrega(idLoja,bairro);
        }
       
        public void ExcluirPratoDaLoja(int idPrato)
        {
            this.lojaService.ExcluirPratoDaLoja(idPrato);
        }

    }
}