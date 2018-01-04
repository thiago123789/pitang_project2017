using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Repositories;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Repositories.Impl
{
    //Lembrar perguntar BURGO SOBRE ISSO POR QUÊ TÁ DANDO PROBLEMA QUANDO USA A INTERFACE???
    public class EFRepository<T,TId> : IRepository<T, TId> where T : EntidadeBase<TId>
        where TId : IEquatable<TId>, IComparable
    {
        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public T GetOne(TId entityId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> List()
        {
            throw new NotImplementedException();
        }

        public void Save(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
