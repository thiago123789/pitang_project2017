using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Entities {
    public class EntidadeBase<TId> : IEntidadeBase<TId>
        where TId: IEquatable<TId>, IComparable<TId>
    {
        public TId Id { get; set; }
    }


   public interface IEntidadeBase<TId> where TId: IEquatable<TId>, IComparable<TId>
   {
        TId Id { get; set; }
    }

}