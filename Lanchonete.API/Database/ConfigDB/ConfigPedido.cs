using Lanchonete.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lanchonete.API.Database.ConfigDB
{
    public class ConfigPedido : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasOne<Caixa>()
                .WithMany()
                .HasForeignKey(h => h.CaixaId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
