using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Repositories;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Repositories.Impl
{
    class PratoMemoryRepository : IPratoRepository
    {
        private readonly IList<Prato> repositorio = new List<Prato>();
        public void Delete(int entityId)
        {
            var query = (from p in this.repositorio
                         where p.Id == entityId
                         select p).FirstOrDefault();
            repositorio.Remove(query);
        }

        public Prato GetOne(int entityId)
        {
            var query = (from p in this.repositorio
                         where p.Id == entityId
                         select p).FirstOrDefault();
            return query;
        }

        public IEnumerable<Prato> List()
        {
            return this.repositorio;
        }

        public void Save(Prato entity)
        {
            this.repositorio.Add(entity);
        }
    }
}
