using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Repositories;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;


namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Repositories.Impl
{
    public class PedidoMemoryRepository : IRepository<Pedido, long>
    {

        private readonly IList<Pedido> repositorio = new List<Pedido>(); 

        public void Delete(Pedido entity)
        {
            this.repositorio.Remove(entity);
        }

        public Pedido GetOne(long entityId)
        {
            var query = (from p in this.repositorio
                        where p.Id == entityId
                        select p).FirstOrDefault();
            return query;
        }

        public IEnumerable<Pedido> List()
        {
            return this.repositorio;
        }

        public void Save(Pedido entity)
        {
            this.repositorio.Add(entity);
        }
    }
}
