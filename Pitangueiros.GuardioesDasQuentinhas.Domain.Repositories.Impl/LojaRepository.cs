using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Repositories;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Repositories.Impl
{
    class LojaRepository : ILojaRepository
    {
        void IRepository<Loja, int>.Delete(int entityId)
        {
            throw new NotImplementedException();
        }

        Loja IRepository<Loja, int>.GetOne(int entityId)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Loja> IRepository<Loja, int>.List()
        {
            throw new NotImplementedException();
        }

        void IRepository<Loja, int>.Save(Loja entity)
        {
            throw new NotImplementedException();
        }
    }
}
