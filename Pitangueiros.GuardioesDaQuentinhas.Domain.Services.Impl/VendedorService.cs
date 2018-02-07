﻿using System;
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

        public void AtualizarLoja(int idLoja, Loja lojaAtualizada)
        {
            Loja loja = lojaRepository.Find(idLoja);
            if (lojaAtualizada.Nome != null)
            {
                loja.Nome = lojaAtualizada.Nome;
            }

            if (lojaAtualizada.EnderecoDaLoja != null)
            {
                loja.EnderecoDaLoja = lojaAtualizada.EnderecoDaLoja;
            }
            this.lojaRepository.Save();
        }

        public void CadastrarLoja(long idVendedor, Loja loja)
        {
            if (loja != null)
            {
                Usuario vendedor = this.usuarioRepository.Find(idVendedor);
                loja.Vendedor = vendedor;
                vendedor.Lojas.Add(loja);
                this.usuarioRepository.Save();

            }
        }

        public void DesativarLoja(int idLoja)
        {
            Loja loja = this.lojaRepository.Find(idLoja);
            this.lojaRepository.Desativar(loja);
            this.lojaRepository.Save();
        }

        public IList<Loja> ListarLojasVendedor(long idVendedor)
        {
            IList<Loja> lojas = this.usuarioRepository.Find(idVendedor).Lojas;
            this.usuarioRepository.Save();
            return lojas;
        }
    }
}
