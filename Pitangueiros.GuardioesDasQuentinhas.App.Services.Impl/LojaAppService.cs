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
        public void AtualizarStatusDoPedido(AtualizarStatusInputDto atualizar)
        {
            this.lojaService.AtualizarStatusDoPedido(atualizar.IdPedido, atualizar.Status);
        }

        public void CriarNovaPorcao(PorcaoInputDto porcao)
        {
            this.lojaService.CriarNovaPorcao(porcao.IdLoja,new Porcao
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
       /* 
        public void DefinirAreaDeEntrega(DefinirAreaDeEntregaDto areas)
        {
           this.lojaService.DefinirAreaDeEntrega(areas.idLoja,areas.Bairros);
        }
       */ 
        public void ExcluirPratoDaLoja(int id)
        {
            this.lojaService.ExcluirPratoDaLoja(id);
        }

    }
}