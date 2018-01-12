using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Repositories;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Repositories.Impl
{
    public class CartaoMemoryRepository : ICartaoRepository
    {
        private readonly IList<Cartao> repositorio = new List<Cartao>();
        public void Delete(int entityId)
        {
            var query = (from c in this.repositorio
                         where c.Id == entityId
                         select c).FirstOrDefault();
            repositorio.Remove(query);
        }

        public Cartao GetOne(int entityId)
        {
            var query = (from c in this.repositorio
                         where c.Id == entityId
                         select c).FirstOrDefault();
            return query;
        }

        public IEnumerable<Cartao> List()
        {
            return this.repositorio;
        }

        public void Save(Cartao entity)
        {
            this.repositorio.Add(entity);
        }
    }
}
