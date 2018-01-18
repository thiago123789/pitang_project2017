using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Services;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Repositories;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;
using System.Collections;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Services.Impl
{
    public class VendedorService : IVendedorService
    {
        private readonly ILojaRepository lojaRepository;
        private readonly IVendedorRepository vendedorRepository;

        public VendedorService(ILojaRepository lojaRepository, 
            IVendedorRepository vendedorRepository)
        {
            this.lojaRepository = lojaRepository;
            this.vendedorRepository = vendedorRepository;
        }

        public void CadastrarLoja(long id, Loja loja)
        {
            if (loja != null) this.lojaRepository.Save(loja);
            Vendedor vendedor = this.vendedorRepository.GetOne(id);
            vendedor.Lojas.Add(loja);
            this.vendedorRepository.Save(vendedor);
        }

        public void DesativarLoja(string nomeLoja)
        {
            Loja loja = this.lojaRepository.ObterPorNome(nomeLoja);
            this.lojaRepository.Delete(loja.Id);
        }
    }
}
