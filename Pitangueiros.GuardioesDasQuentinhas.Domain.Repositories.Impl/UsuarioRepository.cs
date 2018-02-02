using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Repositories;
using System.Data.Entity;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Repositories.Impl
{
    public class UsuarioRepository : EFRepository<Usuario, long>, IUsuarioRepository
    {
        public UsuarioRepository(DbContext context) : base(context)
        {

        }
        public Usuario ObterPorLogin(string email)
        {
            var query = from usuario in Table
                        where usuario.Email == email
                        select usuario;
        
            return query.SingleOrDefault();
        }
    }
}
