using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.App.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.App.Contracts
{
    public interface IUsuarioAppService : IAppService
    {
        bool Autenticar(AutenticacaoInputDto login);

        void CriarUsuario(UsuarioInputDto usuario);

        void DesativarUsuario(DesativarUsuarioInputDto login);
    }
}
