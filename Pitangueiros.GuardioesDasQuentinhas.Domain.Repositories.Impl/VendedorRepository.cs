using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Repositories;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;


namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Repositories.Impl
{
    public class VendedorRepository : IVendedorRepository
    {
        void IRepository<Vendedor, long>.Delete(long entityId)
        {
            throw new NotImplementedException();
        }

        Vendedor IRepository<Vendedor, long>.GetOne(long entityId)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Vendedor> IRepository<Vendedor, long>.List()
        {
            throw new NotImplementedException();
        }

        void IRepository<Vendedor, long>.Save(Vendedor entity)
        {
            throw new NotImplementedException();
        }
    }
}
