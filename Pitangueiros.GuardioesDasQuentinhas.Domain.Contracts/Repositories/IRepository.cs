﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Cross.IoC.Contracts;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Contracts.Repositories
{
    public interface IRepository<T, TId> : IDependenciaTransient
        where T: IEntidadeBase<TId>
        where TId: IEquatable<TId>, IComparable<TId> 
    {
        void Add(T entity);
        void Save();
        T GetOne(TId entityId);
        ICollection<T> ListActive();
        ICollection<T> ListAll();
        void Desativar(T entity);
        T Find(TId entityId);
        IList<T> FindList(IList<TId> listEntityId);
        void Dispose();
        void Detach(T entity);
        void Attach(T entity);
    }
}
