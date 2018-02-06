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
    class PagamentoMapping : EntityTypeConfiguration<Pagamento>
    {
        public PagamentoMapping()
        {
            ToTable("Pagamento");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.OpcaoDePagamento)
                .HasColumnName("OpcaoPagamento");
            this.Property(p => p.DataCriacao)
                .HasColumnName("DataCriacao")
                .IsRequired();
            this.Property(p => p.IsDeleted)
                .HasColumnName("IsDeleted")
                .IsRequired();
            this.Property(p => p.UltimaModificacao)
                .HasColumnName("UltimaModificacao")
                .IsOptional();
            this.HasRequired<Pedido>(p => p.Pedido)
                .WithOptional(p => p.Pagamento)
                .Map(c => c.MapKey("PedidoId"));
        }
    }
}
