using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Repositories.Impl.Mapping
{
    class UsuarioBaseMapping<T> : EntityTypeConfiguration<T> where T : Usuario
    {
        public UsuarioBaseMapping()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();
            this.Property(p => p.Nome)
                .HasColumnName("Nome").IsRequired();
            this.Property(p => p.Email)
                .HasColumnName("Email").IsRequired();
            this.Property(p => p.Senha)
                .HasColumnName("Senha").IsRequired();

        }
    }
}
