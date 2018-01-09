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
    class PorcaoMapping : EntityTypeConfiguration<Porcao>
    {
        public PorcaoMapping()
        {
            ToTable("Porcao");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.Item)
                .HasColumnName("Item");
            this.Property(p => p.Preco)
                .HasColumnName("Preco");
            this.Property(p => p.Quantidade)
                .HasColumnName("Quantidade");
        }
    }
}
