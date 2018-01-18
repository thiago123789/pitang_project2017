using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Repositories.Impl.Mapping
{
    class PratoMapping : EntityTypeConfiguration<Prato>
    {
            ToTable("Prato");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.Preco)
                .HasColumnName("Preco").IsRequired();
            this.Property(p => p.IsDeleted)
                .HasColumnName("IsDeleted").IsRequired();
            this.HasRequired<Pedido>(p => p.Pedido)
                .WithMany(s => s.Prato);
    }
}
