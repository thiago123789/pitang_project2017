using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Repositories;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Repositories.Impl
{
    public class UsuarioMemoryRepository : IUsuarioRepository
    {
        private readonly IList<Usuario> repositorio = new List<Usuario>();
        public void Delete(Usuario entity)
        {
            this.repositorio.Remove(entity);
        }
        
        public Usuario GetOne(long entityId)
        {
            var query = (from u in this.repositorio
                         where u.Id == entityId
                         select u).FirstOrDefault();
            return query;
        }

        public IEnumerable<Usuario> List()
        {
            return this.repositorio;
        }

        public Usuario ObterPorLogin(string email)
        {
            throw new NotImplementedException();
        }

        public void Save(Usuario entity)
        {
            this.repositorio.Add(entity);
        }
    }
}
