using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Repositories.Impl.Mapping
{
    public class UsuarioMapping : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMapping()
        {
            ToTable("Usuario");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();
            this.Property(p => p.Nome)
                .HasColumnName("Nome").IsRequired();
            this.Property(p => p.Email)
                .HasColumnName("Email").IsRequired();
            this.Property(p => p.Senha)
                .HasColumnName("Senha").IsRequired();
            this.Property(p => p.IsDeleted)
                .HasColumnName("IsDeleted").IsRequired();
            this.Property(p => p.DataCriacao)
                .HasColumnName("DataCriacao")
                .IsRequired();
            this.Property(p => p.UltimaModificacao)
                .HasColumnName("UltimaModificacao")
                .IsOptional();
            this.HasMany<Permissao>(c => c.Permissoes)
                .WithMany(c => c.Usuarios)
                .Map(cs => {
                    cs.MapLeftKey ("UsuarioId");
                    cs.MapRightKey("PermissaoId");
                    cs.ToTable("PermissaoUsuario");
                });
            this.HasMany(c => c.Cartoes)
                .WithRequired(c => c.Cliente);
            this.HasMany<Loja>(s => s.Lojas)
                .WithRequired(s => s.Vendedor);
        }
    }
}
