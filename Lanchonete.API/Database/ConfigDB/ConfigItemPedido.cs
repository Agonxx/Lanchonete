using Lanchonete.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lanchonete.API.Database.ConfigDB
{
    public class ConfigItemPedido : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            builder.HasOne<Pedido>()
                .WithMany()
                .HasForeignKey(h => h.PedidoId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<Categoria>()
                .WithMany()
                .HasForeignKey(h => h.CategoriaId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
