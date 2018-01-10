using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;
using Pitangueiros.GuardioesDasQuentinhas.Cross.IoC.Contracts;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Repositories
{
    public interface IUsuarioRepository: IRepository<Usuario, long>, IDependenciaTransient
    {
        Usuario ObterPorLogin(string email);

    }
}
