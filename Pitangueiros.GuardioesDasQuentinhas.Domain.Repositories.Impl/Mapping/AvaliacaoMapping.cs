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
    class AvaliacaoMapping : EntityTypeConfiguration<Avaliacao>
    {
        public AvaliacaoMapping()
        {
            ToTable("Avaliacao");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.Nota)
                .HasColumnName("Nota").IsRequired();
            this.Property(p => p.DataAvaliacao)
                .HasColumnName("DataAvaliacao").IsRequired();
            this.Property(p => p.Comentario)
                .HasColumnName("Comentario");
            this.Property(p => p.IsDeleted)
                .HasColumnName("IsDeleted")
                .IsRequired();
            this.Property(p => p.DataCriacao)
                .HasColumnName("DataCriacao")
                .IsRequired();
            this.Property(p => p.UltimaModificacao)
                .HasColumnName("UltimaModificacao")
                .IsOptional();
        }
    }
}
