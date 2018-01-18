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
    class CartaoMapping : EntityTypeConfiguration<Cartao>
    {
        public CartaoMapping()
        {
            ToTable("Cartao");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.NomeTitular)
                .HasColumnName("NomeTitular").IsRequired();
            this.Property(p => p.Numero)
                .HasColumnName("NumeroCartao").IsRequired();
            this.Property(p => p.Validade)
                .HasColumnName("Validade").IsRequired();
            this.Property(p => p.CodSeg)
                .HasColumnName("CodSeg").IsRequired();
            this.Property(p => p.Bandeira)
                .HasColumnName("Bandeira").IsRequired();
            this.Property(p => p.IsDeleted)
                .HasColumnName("IsDeleted").IsRequired();
            this.HasRequired<Cliente>(s => s.Cliente)
                .WithMany(c => c.Cartao);
        }
    }
}
