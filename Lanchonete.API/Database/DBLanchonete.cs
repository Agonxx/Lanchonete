using Lanchonete.API.Database.ConfigDB;
using Lanchonete.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Lanchonete.API.Database
{
    public class DBLanchonete : DbContext
    {
        public DBLanchonete(DbContextOptions<DBLanchonete> options) : base(options)
        {
        }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ItemPedido> ItensPedido { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Caixa> Caixas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ConfigCategoria());
            modelBuilder.ApplyConfiguration(new ConfigProduto());
            modelBuilder.ApplyConfiguration(new ConfigPedido());
            modelBuilder.ApplyConfiguration(new ConfigItemPedido());
        }
    }
}
