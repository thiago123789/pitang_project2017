﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Repositories.Impl.Mapping
{
    class PratoMapping : EntityTypeConfiguration<Prato>
    {
        public PratoMapping()
        {
            ToTable("Prato");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            //this.HasOptional<Pedido>(p => p.Pedido)
            //    .WithMany(p => p.Pratos)
            //    .Map(a => a.MapKey("PedidoId"));
            this.HasMany<Pedido>(s => s.Pedidos)
                .WithMany(c => c.Pratos)
                .Map(cs =>
                {
                    cs.MapLeftKey("PratoId");
                    cs.MapRightKey("PedidoId");
                    cs.ToTable("PedidoPrato");
                });
            this.Property(p => p.Preco)
                .HasColumnName("Preco")
                .IsRequired();
            this.Property(p => p.IsDeleted)
                .HasColumnName("IsDeleted")
                .IsRequired();
            this.Property(p => p.DataCriacao)
                .HasColumnName("DataCriacao")
                .IsRequired();
            this.Property(p => p.CriadoPorVendedor)
                .HasColumnName("CriadoPorVendedor")
                .IsRequired();
            this.Property(p => p.UltimaModificacao)
                .HasColumnName("UltimaModificacao")
                .IsOptional();
            this.HasMany<Porcao>(s => s.Porcoes)
                .WithMany(c => c.Pratos)
                .Map(cs =>
                {
                    cs.MapLeftKey("PratoId");
                    cs.MapRightKey("PorcaoId");
                    cs.ToTable("PratoPorcao");
                });
            this.HasRequired<Loja>(s => s.Loja)
                .WithMany(s => s.Pratos)
                .Map(a => a.MapKey("LojaId"));
        }
            
    }
}
