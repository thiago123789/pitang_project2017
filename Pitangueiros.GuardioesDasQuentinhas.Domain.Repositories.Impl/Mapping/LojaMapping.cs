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
            this.Property(p => p.CEPDaLoja)
                .HasColumnName("CEP");
            this.HasRequired<Vendedor>(s => s.Vendedor)
                .WithMany(c => c.Lojas);
        }
    }
}
