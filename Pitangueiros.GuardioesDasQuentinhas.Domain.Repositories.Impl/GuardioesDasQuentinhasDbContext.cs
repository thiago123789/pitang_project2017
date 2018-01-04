using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Pitangueiros.GuardioesDasQuentinhas.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pitangueiros.GuardioesDasQuentinhas.Domain.Repositories.Impl
{
    public class GuardioesDasQuentinhasDbContext : DbContext{
        public GuardioesDasQuentinhasDbContext() /*: base ("A gente n")*/{

        }
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Vendedor> Vendedores { get; set; }

        public DbSet<Loja> Lojas { get; set; }

        public DbSet<Cartao> Cartoes { get; set; }

        public DbSet<Porcao> Porcoes { get; set; }

        public DbSet<Pagamento> Pagamentos { get; set; }

        public DbSet<Comentario> Comentarios { get; set; }

        public DbSet<Avaliacao> Avaliacoes { get; set; }

        public DbSet<Pedido> Pedidos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Mapeamento de Usuario
            modelBuilder.Entity<Usuario>()
                .HasKey(p => p.Id);
            modelBuilder.Entity<Usuario>().Property(p => p.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Usuario>().Property(p => p.Nome)
                .HasColumnName("Nome");
            modelBuilder.Entity<Usuario>().Property(p => p.Email)
                .HasColumnName("Email");
            modelBuilder.Entity<Usuario>().Property(p => p.Senha)
                .HasColumnName("Senhas");


            base.OnModelCreating(modelBuilder);
        }
        //mapeamento
    }
}
