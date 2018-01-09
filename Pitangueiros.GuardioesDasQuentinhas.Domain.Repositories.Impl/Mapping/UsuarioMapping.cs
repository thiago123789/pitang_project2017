using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Repositories.Impl.Mapping
{
    class UsuarioMapping : UsuarioBaseMapping<Usuario>
    {
        public UsuarioMapping()
        {
            ToTable("Usuario");
        }
    }
}
