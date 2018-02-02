using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Repositories;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Repositories.Impl
{
    public class PagamentoRepository : EFRepository<Pagamento, long>, IPagamentoRepository
    {
        public PagamentoRepository(GuardioesDasQuentinhasDbContext context) : base(context)
        {

        }
    }
}
