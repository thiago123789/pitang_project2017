using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Services;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Repositories;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;
using Pitangueiros.GuardioesDasQuentinhas.Cross.IoC.Contracts;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Services.Impl
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository usuarioRepository;
        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            this.usuarioRepository = usuarioRepository;
        }
        public bool Autenticar(string email, string senha)
        {
            Usuario usuario = this.usuarioRepository.ObterPorLogin(email);
            bool autenticado = false;
            if (usuario != null)
            {
                autenticado = usuario.Senha == senha;
            }

            return autenticado;
        }

        public void CriarUsuario(Usuario usuario)
        {
            this.usuarioRepository.Save(usuario);
        }

        public void DesativarUsuario(int id)
        {
            this.usuarioRepository.Delete(id);
        }
    }
}
