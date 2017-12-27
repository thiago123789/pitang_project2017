using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Repositories
{
    public interface IRepository<T, TId>
        where T: EntidadeBase<TId>
        where TId: IEquatable<TId>, IComparable{

        void Save(T entity);
        T GetOne(TId entityId);
        IEnumerable<T> List();
        void Delete(TId entityId);
    }
}
