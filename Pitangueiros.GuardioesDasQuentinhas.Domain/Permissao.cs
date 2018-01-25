using System.Collections.Generic;
using System.Security.Permissions;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Entities
{
    public class Permissao
    {
        public int Id { get; set; }
        public PapelUsuario Papel { get; set; }
        public IList<Usuario> Usuarios { get; set; }
    }
}