using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Repositories;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Repositories.Impl
{
    public class ClienteMemoryRepository : IClienteRepository
    {
        private readonly IList<Cliente> repositorio = new List<Cliente>();

        public void Delete(long entityId)
        {
            var query = (from c in this.repositorio
                         where c.Id == entityId
                         select c).FirstOrDefault();
            repositorio.Remove(query);
        }

        public Cliente GetOne(long entityId)
        {
            var query = (from c in this.repositorio
                         where c.Id == entityId
                         select c).FirstOrDefault();
            return query;
        }

        public IEnumerable<Cliente> List()
        {
            return this.repositorio;
        }

        public void Save(Cliente entity)
        {
            this.repositorio.Add(entity);
        }
    }
}
