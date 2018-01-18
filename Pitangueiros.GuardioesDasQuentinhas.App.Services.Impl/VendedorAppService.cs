using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.App.Contracts;
using Pitangueiros.GuardioesDasQuentinhas.App.Entities;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Services;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.App.Services.Impl
{
    public class VendedorAppService : IVendedorAppService
    {
        private readonly IVendedorService vendedorService;
        public VendedorAppService(IVendedorService vendedorService)
        {
            this.vendedorService = vendedorService;
        }
        public void CadastrarLoja(LojaInputDto loja)
        {
            this.vendedorService.CadastrarLoja(loja.IdVendedor, new Loja
            {
                Nome = loja.Nome,
                EnderecoDaLoja = loja.Endereco,
                BairrosDeEntrega = loja.Bairros
            });
        }

        public void DesativarLoja(DesativarLojaInputDto nomeLoja)
        {
            this.vendedorService.DesativarLoja(nomeLoja.Nome);
        }
    }
}
