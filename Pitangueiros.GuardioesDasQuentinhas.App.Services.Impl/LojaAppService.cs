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

        public void CriarNovaPorcao(int idLoja,PorcaoInputDto porcaoInput)
        {
            this.lojaService.CriarNovaPorcao(idLoja,new Porcao
            {
                Item = porcaoInput.Item,
                Preco = porcaoInput.Preco,
                Quantidade = porcaoInput.Quantidade,
                CategoriaPorcao = porcaoInput.Categoria,
            });
        }

        public void CriarNovoPrato(int idLoja, PratoInputDto pratoInput)
        {

            this.lojaService.CriarNovoPrato(new Prato
            {
                Porcao = pratoInput.Porcoes,
                Preco = pratoInput.Preco
            },idLoja);
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