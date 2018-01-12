using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Repositories;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Repositories.Impl
{ 
    public class LojaMemoryRepository : ILojaRepository
    {
        private readonly IList<Loja> repositorio = new List<Loja>();

        public void Delete(int entityId)
        {
            var query = (from l in this.repositorio
                         where l.Id == entityId
                         select l).FirstOrDefault();
            repositorio.Remove(query);
        }

        public Loja GetOne(int entityId)
        {
            var query = (from l in this.repositorio
                        where l.Id == entityId
                        select l).FirstOrDefault();
            return query;
        }

        public IEnumerable<Loja> List()
        {
            return this.repositorio;
        }

        public void Save(Loja entity)
        {
            this.repositorio.Add(entity);
        }
    }
}
