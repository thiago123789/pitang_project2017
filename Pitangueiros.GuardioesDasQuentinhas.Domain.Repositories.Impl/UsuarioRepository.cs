using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Repositories;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Repositories.Impl
{
    class UsuarioRepository : IUsuarioRepository
    {
        void IRepository<Usuario, long>.Delete(long entityId)
        {
            throw new NotImplementedException();
        }

        Usuario IRepository<Usuario, long>.GetOne(long entityId)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Usuario> IRepository<Usuario, long>.List()
        {
            throw new NotImplementedException();
        }

        void IRepository<Usuario, long>.Save(Usuario entity)
        {
            throw new NotImplementedException();
        }
    }
}
