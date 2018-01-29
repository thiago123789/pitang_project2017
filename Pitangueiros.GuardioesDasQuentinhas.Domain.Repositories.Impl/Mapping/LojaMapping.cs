using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Repositories.Impl.Mapping
{
    class LojaMapping : EntityTypeConfiguration<Loja>
    {
        public LojaMapping()
        {
            ToTable("Loja");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.Nome)
                .HasColumnName("Nome");
            this.Property(p => p.EnderecoDaLoja)
                .HasColumnName("EnderecoDaLoja");
            this.Property(p => p.IsDeleted)
                .HasColumnName("IsDeleted").IsRequired();
            this.HasRequired<Usuario>(s => s.Vendedor)
                .WithMany(c => c.Lojas)
                .Map(a => a.MapKey("VendedorId"));
            this.Property(p => p.DataCriacao)
                .HasColumnName("DataCriacao")
                .IsRequired();
            this.Property(p => p.UltimaModificacao)
                .HasColumnName("UltimaModificacao")
                .IsOptional();
            this.HasMany<Porcao>(s => s.Porcoes)
                .WithRequired(s => s.Loja);
        }
    }
}
