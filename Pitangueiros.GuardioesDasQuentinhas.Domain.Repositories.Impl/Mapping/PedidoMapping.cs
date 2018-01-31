using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration.Configuration;

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
            this.HasMany<Prato>(p => p.Pratos)
                .WithOptional(p => p.Pedido);
            this.HasRequired<Loja>(p => p.Loja)
                .WithMany(p => p.Pedidos)
                .Map(a => a.MapKey("LojaId")); 
            this.Property(p => p.Comentario)
                .HasColumnName("Comentario");
            this.Property(p => p.StatusPedido)
                .HasColumnName("StatusPedido");
            this.Property(p => p.Preco)
                .HasColumnName("Preco");
            this.HasRequired<Usuario>(p => p.Cliente)
                .WithMany(p => p.Pedidos)
                .Map(a => a.MapKey("ClienteId"));
            this.HasRequired<Pagamento>(p => p.Pagamento)
                .WithRequiredDependent();
            this.HasOptional<Avaliacao>(p => p.Avaliacao)
                .WithRequired(p => p.Pedido);
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
