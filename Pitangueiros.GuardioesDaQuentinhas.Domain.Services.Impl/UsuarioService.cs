using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Services;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Services.Impl
{
    class UsuarioService : IUsuarioService
    {
        public bool Autenticar(string email, string senha)
        {
            throw new NotImplementedException();
        }

        public void CriarUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void DesativarUsuario(string email)
        {
            throw new NotImplementedException();
        }
    }
}
