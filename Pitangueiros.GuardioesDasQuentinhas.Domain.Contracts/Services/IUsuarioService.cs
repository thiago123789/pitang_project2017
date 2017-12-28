using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Services
{
    public interface IUsuarioService {
        bool Autenticar(String email, String senha);
        //void DesativarUsuario(String email);
        void DesativarUsuario(Usuario usuario);
        void CriarUsuario(Usuario usuario);
    }
}
