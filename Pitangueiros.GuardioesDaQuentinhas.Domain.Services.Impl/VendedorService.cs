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

        public void CadastrarLoja(long idVendedor, Loja loja)
        {
            if (loja != null)
            {
                Usuario vendedor = this.usuarioRepository.GetOne(idVendedor);
                loja.Vendedor = vendedor;
                vendedor.Lojas.Add(loja);
                this.usuarioRepository.Save();
                this.usuarioRepository.Dispose();
                this.lojaRepository.Save(loja);
                //this.usuarioRepository.Update(vendedor);
            }
        }

        public void DesativarLoja(int idLoja)
        {
            Loja loja = this.lojaRepository.GetOne(idLoja);
            this.lojaRepository.Delete(loja.Id);
        }
    }
}
