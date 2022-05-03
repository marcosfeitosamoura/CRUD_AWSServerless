

using Core_Domain;
using Core_Domain.Interface;
using Microsoft.EntityFrameworkCore;

namespace Infra
{
    public class GestaoContext : DbContext
    {
        public GestaoContext(DbContextOptions<GestaoContext> options)
         : base(options)
        {
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<PedidoItem> PedidoItem { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Usuario>().ToTable("TB_Usuario");
            modelBuilder.Entity<Cliente>().ToTable("TB_Cliente");
            modelBuilder.Entity<Produto>().ToTable("TB_Produto");
            modelBuilder.Entity<Pedido>().ToTable("TB_Pedido");
            modelBuilder.Entity<PedidoItem>().ToTable("TB_Pedido_Item");
        }
    }
}
