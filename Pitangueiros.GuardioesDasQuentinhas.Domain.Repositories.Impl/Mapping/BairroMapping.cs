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
    public class BairroMapping : EntityTypeConfiguration<Bairro>
    {
        public BairroMapping()
        {
            ToTable("Bairro");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.Nome)
                .HasColumnName("Nome").IsRequired();
            this.Property(p => p.IsDeleted)
                .HasColumnName("IsDeleted")
                 .IsRequired();
            this.Property(p => p.DataCriacao)
                .HasColumnName("DataCriacao")
                .IsRequired();
            this.Property(p => p.UltimaModificacao)
                .HasColumnName("UltimaModificacao")
                .IsOptional();
            this.HasRequired<Loja>(s => s.Loja)
                .WithMany(s => s.Bairros)
                .Map(a => a.MapKey("LojaId"));
        }
    }
}
