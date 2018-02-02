﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Repositories;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;
using System.Data.Entity;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Repositories.Impl
{
    public class EFRepository<T, TId> : IRepository<T, TId>, IDisposable
        where T : class, IEntidadeBase<TId>, new()
        where TId : IComparable<TId>, IEquatable<TId>
    {
        protected DbContext Context { get; }

        protected DbSet<T> Table => Context.Set<T>();

        public EFRepository(DbContext context)
        {
            this.Context = context;
        }
        public void Desativar(T entity)
        {
            //var entity_rtn = (from entity in Context.Set<T>()
            //where entity.Id.Equals(entityId)
            //select entity).SingleOrDefault();

            if (entity is IDeleteLogico)
            {
                ((IDeleteLogico)entity).IsDeleted = true;
            }

        }

        public T GetOne(TId entityId)
        {
            var query = from entity in Context.Set<T>()
                        where entity.Id.Equals(entityId)
                        select entity;
            return query.SingleOrDefault();
        }

        public void Add(T entity)
        {
            this.Context.Set<T>().Add(entity);
            //this.Context.Entry(entity).State = EntityState.Added;
            //this.Context.SaveChanges();
        }

        public ICollection<T> ListActive()
        {
            var list = (from entity in Context.Set<T>()
                        where ((IDeleteLogico)entity).IsDeleted
                        select entity).ToList();
            return list;
        }

        public ICollection<T> ListAll()
        {
            var list = (from entity in Context.Set<T>()
                        select entity).ToList();
            return list;
        }

        public void Save()
        {
            this.Context.SaveChanges();
        }

        public T Find(TId entityId)
        {
            return this.Context.Set<T>().Find(entityId);
        }

        public IList<T> FindList(IList<TId> listEntityId)
        {
            var query = (from entity in Context.Set<T>()
                         where listEntityId.Contains(entity.Id)
                         select entity).ToList();

            return query;
        }

        public void Dispose()
        {
            this.Context.Dispose();
        }

        public void Detach(T entity)
        {
            this.Context.Entry(entity).State = EntityState.Detached;
        }

        public void Attach(T entity)
        {
            this.Context.Set(entity.GetType()).Attach(entity);
        }
    }
}
