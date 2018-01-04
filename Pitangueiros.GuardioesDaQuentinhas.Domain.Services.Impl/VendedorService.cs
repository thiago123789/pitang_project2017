using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Services;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Repositories;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Services.Impl
{
    public class VendedorService : IVendedorService
    {
        private readonly ILojaRepository lojaRepository;
        public VendedorService(ILojaRepository lojaRepository)
        {
            this.lojaRepository = lojaRepository;
        }
        public void CadastrarLoja(Loja loja)
        {
            if (loja != null) this.lojaRepository.Save(loja);
        }
        public void RemoverLoja(Loja loja)
        {
            if (loja != null) this.lojaRepository.Delete(loja);
        }
    }
}
