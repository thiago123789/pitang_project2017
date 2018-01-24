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

        public GuardioesDasQuentinhasDbContext() : base("ConnIQuentinhas") {
            Database.SetInitializer<GuardioesDasQuentinhasDbContext>(null);
        }
 
        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Configurations.Add(new VendedorMapping());
            modelBuilder.Configurations.Add(new UsuarioMapping());
            modelBuilder.Configurations.Add(new PratoMapping());
            modelBuilder.Configurations.Add(new PorcaoMapping());
            modelBuilder.Configurations.Add(new PedidoMapping());
            modelBuilder.Configurations.Add(new PagamentoMapping());
            modelBuilder.Configurations.Add(new LojaMapping());
            modelBuilder.Configurations.Add(new ClienteMapping());
            modelBuilder.Configurations.Add(new CartaoMapping());
            modelBuilder.Configurations.Add(new AvaliacaoMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
