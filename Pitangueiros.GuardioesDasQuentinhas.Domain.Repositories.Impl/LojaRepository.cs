using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Repositories;
using System.Data.Entity;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Repositories.Impl
{
    public class LojaRepository : EFRepository<Loja, int>, ILojaRepository
    {
        public LojaRepository(DbContext context) : base(context)
        {

        }

        //public Loja ObterPorNome(string nomeLoja)
        //{
        //    var query = from loja in Table
        //                where loja.Nome == nomeLoja
        //                select loja;
        //
        //    return query.SingleOrDefault();
        //}
    }
}
