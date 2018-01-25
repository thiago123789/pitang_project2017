using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Cross.IoC.Contracts;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Services
{
    public interface IUsuarioService : IDependenciaTransient {
        bool Autenticar(string email, string senha);
        void DesativarUsuario(string email);
        void CriarUsuario(Usuario usuario, IList<string> papeis);
    }
}
