using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Repositories;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;
using System.Data.Entity;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Repositories.Impl
{
    public class EFRepository<T, TId> : IRepository<T, TId> 
        where T : class, IEntidadeBase<TId>, new()
        where TId : IComparable<TId>, IEquatable<TId> 
    {
        protected DbContext Context { get; }

        protected DbSet<T> Table => Context.Set<T>();

        public EFRepository(DbContext context)
        {
            this.Context = context;
        }
        public void Delete(T entity)
        {
            this.Context.Set<T>().Remove(entity);
            this.Context.SaveChanges();
        }

        public T GetOne(TId entityId)
        {
            var query = from entity in Context.Set<T>()
                        where entity.Id.Equals(entityId)
                        select entity;
            return query.SingleOrDefault();
        }

        public void Save(T entity)
        {
            this.Context.Set<T>().Add(entity);
            this.Context.SaveChanges();
        }
    }
}
