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

        public void Delete(Cliente entity)
        {
            throw new NotImplementedException();
        }

        public Cliente GetOne(long entityId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cliente> List()
        {
            throw new NotImplementedException();
        }

        public void Save(Cliente entity)
        {
            throw new NotImplementedException();
        }
    }
}
