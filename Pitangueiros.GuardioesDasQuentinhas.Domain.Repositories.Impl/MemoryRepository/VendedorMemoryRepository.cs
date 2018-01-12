using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Repositories;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;


namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Repositories.Impl
{
    public class VendedorMemoryRepository : IVendedorRepository
    {
        private readonly IList<Vendedor> repositorio = new List<Vendedor>();
        public void Delete(long entityId)
        {
            var query = (from v in this.repositorio
                         where v.Id == entityId
                         select v).FirstOrDefault();
            repositorio.Remove(query);
        }

        public Vendedor GetOne(long entityId)
        {
            var query = (from v in this.repositorio
                         where v.Id == entityId
                         select v).FirstOrDefault();
            return query;

        }

        public IEnumerable<Vendedor> List()
        {
            return this.repositorio;
        }

        public void Save(Vendedor entity)
        {
            this.repositorio.Add(entity);
        }
    }
}
