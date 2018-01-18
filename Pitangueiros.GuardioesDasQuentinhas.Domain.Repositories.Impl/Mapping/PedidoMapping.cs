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
    class PedidoMapping : EntityTypeConfiguration<Pedido>
    {
        public PedidoMapping()
        {
            ToTable("Pedido");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.HasRequired<Cliente>(p => p.Cliente)
                .WithMany(p => p.Pedido);
            this.HasRequired<Loja>(p => p.Loja)
                .WithMany();
            this.Property(p => p.Comentario)
                .HasColumnName("Comentario");
            this.HasRequired<Pagamento>(p => p.Pagamento)
                .WithRequiredDependent();
            this.Property(p => p.Preco)
                .HasColumnName("Preco");
            this.Property(p => p.StatusPedido)
                .HasColumnName("Status");
        }
    }
}
