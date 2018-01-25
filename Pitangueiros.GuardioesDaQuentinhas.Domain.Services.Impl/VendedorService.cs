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
        private readonly IUsuarioRepository usuarioRepository;

        public VendedorService(ILojaRepository lojaRepository,
            IUsuarioRepository usuarioRepository)
        {
            this.lojaRepository = lojaRepository;
            this.usuarioRepository = usuarioRepository;
        }

        public void CadastrarLoja(long id, Loja loja)
        {
            if (loja != null) this.lojaRepository.Save(loja);
            Usuario vendedor = this.usuarioRepository.GetOne(id);
            vendedor.Lojas.Add(loja);
            this.usuarioRepository.Save(vendedor);
        }

        public void DesativarLoja(string nomeLoja)
        {
            Loja loja = this.lojaRepository.ObterPorNome(nomeLoja);
            this.lojaRepository.Delete(loja.Id);
        }
    }
}
