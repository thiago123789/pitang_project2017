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
            this.HasMany(p => p.Pratos)
                .WithRequired();
            this.HasRequired(p => p.Loja)
                .WithMany();
            this.Property(p => p.Comentario)
                .HasColumnName("Comentario");
            this.Property(p => p.Preco)
                .HasColumnName("Preco");
            this.Property(p => p.StatusPedido)
                .HasColumnName("Status");
            this.HasRequired<Usuario>(p => p.Cliente)
                .WithMany(p => p.Pedido);
            this.HasRequired<Pagamento>(p => p.Pagamento)
                .WithRequiredDependent();
            this.HasRequired(p => p.Avaliacao)
                .WithOptional();
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
