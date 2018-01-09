using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Repositories.Impl.Mapping
{
    class ClienteMapping : UsuarioBaseMapping<Cliente>
    {
        public ClienteMapping()
        {
            ToTable("Cliente");
            this.HasMany(c => c.Cartao).WithRequired(c => c.Cliente);
        }
        

    }
}
