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
        public VendedorService(ILojaRepository lojaRepository)
        {
            this.lojaRepository = lojaRepository;
        }

        //public void CadastrarAreaEntrega(IList CEPs)
        //{
        //    throw new NotImplementedException();
        //}

        public void CadastrarLoja(Loja loja)
        {
            if (loja != null) this.lojaRepository.Save(loja);
        }
        public void DesativarLoja(string nomeLoja)
        {
            Loja loja = this.lojaRepository.ObterPorNome(nomeLoja);
            this.lojaRepository.Delete(loja.Id);
        }
    }
}
