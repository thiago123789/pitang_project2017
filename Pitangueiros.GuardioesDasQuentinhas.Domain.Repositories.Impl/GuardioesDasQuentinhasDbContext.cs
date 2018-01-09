using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Repositories.Impl.Mapping;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Repositories.Impl
{
    public class GuardioesDasQuentinhasDbContext : DbContext{

        public GuardioesDasQuentinhasDbContext() {

        }
        /*public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Vendedor> Vendedores { get; set; }

        public DbSet<Loja> Lojas { get; set; }

        public DbSet<Cartao> Cartoes { get; set; }

        public DbSet<Porcao> Porcoes { get; set; }

        public DbSet<Pagamento> Pagamentos { get; set; }

        public DbSet<Comentario> Comentarios { get; set; }

        public DbSet<Avaliacao> Avaliacoes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }*/

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new VendedorMapping());
            modelBuilder.Configurations.Add(new UsuarioMapping());
            modelBuilder.Configurations.Add(new PratoMapping());
            modelBuilder.Configurations.Add(new PorcaoMapping());
            modelBuilder.Configurations.Add(new PedidoMapping());
            modelBuilder.Configurations.Add(new PagamentoMapping());
            modelBuilder.Configurations.Add(new LojaMapping());
            //modelBuilder.Configurations.Add(new EntidadeBaseMapping());
            modelBuilder.Configurations.Add(new ComentarioMapping());
            modelBuilder.Configurations.Add(new ClienteMapping());
            modelBuilder.Configurations.Add(new CartaoMapping());
            modelBuilder.Configurations.Add(new AvaliacaoMapping());

            /*
            
            //Mapeamento de Cartao
            modelBuilder.Entity<Cartao>()
                .HasKey(p => p.Id);
            modelBuilder.Entity<Cartao>()
                .Property(p => p.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Cartao>()
                .Property(p => p.NomeTitular)
                .HasColumnName("NomeTitular");
            modelBuilder.Entity<Cartao>()
                .Property(p => p.Numero)
                .HasColumnName("NumeroCartao");
            modelBuilder.Entity<Cartao>()
                .Property(p => p.Validade)
                .HasColumnName("Validade");
            modelBuilder.Entity<Cartao>()
                .Property(p => p.CodSeg)
                .HasColumnName("CodSeg");
            modelBuilder.Entity<Cartao>()
                .Property(p => p.Bandeira)
                .HasColumnName("Bandeira");
            modelBuilder.Entity<Cartao>()
                .HasRequired<Cliente>(s => s.Cliente)
                .WithMany(c => c.Cartao);

            //Mapeamento de Lojas
            modelBuilder.Entity<Loja>()
                .HasKey(p => p.Id);
            modelBuilder.Entity<Loja>().Property(p => p.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Loja>().Property(p => p.Nome)
                .HasColumnName("Nome");
            modelBuilder.Entity<Loja>().Property(p => p.CEP)
                .HasColumnName("CEP");
            modelBuilder.Entity<Loja>()
                .HasRequired<Vendedor>(s => s.Vendedor)
                .WithMany(c => c.Lojas);

            //Mapeamento Porcao
            modelBuilder.Entity<Porcao>()
                .HasKey(p => p.Id);
            modelBuilder.Entity<Porcao>()
                .Property(p => p.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Porcao>()
                .Property(p => p.Item)
                .HasColumnName("Item");
            modelBuilder.Entity<Porcao>()
                .Property(p => p.Preco)
                .HasColumnName("Preco");
            modelBuilder.Entity<Porcao>()
                .Property(p => p.Quantidade)
                .HasColumnName("Quantidade");

            //Mapeamento Comentario
            modelBuilder.Entity<Comentario>()
                .HasKey(p => p.Id);
            modelBuilder.Entity<Comentario>()
                .Property(p => p.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Comentario>()
                .Property(p => p.Texto)
                .HasColumnName("Texto");

            //Mapeamento Pagamento
            modelBuilder.Entity<Pagamento>()
                .HasKey(p => p.Id);
            modelBuilder.Entity<Pagamento>()
                .Property(p => p.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Pagamento>()
                .Property(p => p.OpcaoDePagamento)
                .HasColumnName("OpcaoPagamento");

            //Mapeamento Avaliacao
            modelBuilder.Entity<Avaliacao>()
                .HasKey(p => p.Id);

            ////Mapeamento Pedido
            //modelBuilder.Entity<Pedido>()
            //    .HasKey(p => p.Id);
            //modelBuilder.Entity<Pedido>().Property(p => p.Id)
            //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            //modelBuilder.Entity<Pedido>()
            //    .Property(p => p.Cliente)
            //    .HasColumnName("ClienteId");
            //modelBuilder.Entity<Pedido>().Property(p => p.LojaId)
            //    .HasColumnName("Loja");
            //modelBuilder.Entity<Pedido>().Property(p => p.ComentarioId)
            //    .HasColumnName("Comentario");
            //modelBuilder.Entity<Pedido>().Property(p => p.PagamentoId)
            // .HasColumnName("Pagamento");
            //modelBuilder.Entity<Pedido>().Property(p => p.Preco)
            //    .HasColumnName("Preco");
            //modelBuilder.Entity<Pedido>().Property(p => p.StatusPedido)
            //    .HasColumnName("Status");
            */

            base.OnModelCreating(modelBuilder);
        }
        //mapeamento
    }
}
