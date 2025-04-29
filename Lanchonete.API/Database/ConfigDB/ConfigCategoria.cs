using Lanchonete.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lanchonete.API.Database.ConfigDB
{
    public class ConfigCategoria : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasData(new Categoria[]
             {
                new Categoria { Id = 1,  Descricao = "Bauru", CadastradoEm = DateTime.Now },
                new Categoria { Id = 2,  Descricao = "Hambúrguer", CadastradoEm = DateTime.Now },
                new Categoria { Id = 3,  Descricao = "Pastel Simples", CadastradoEm = DateTime.Now },
                new Categoria { Id = 4,  Descricao = "Pastel Especial", CadastradoEm = DateTime.Now },
                new Categoria { Id = 5,  Descricao = "Mini Pastel", CadastradoEm = DateTime.Now },
                new Categoria { Id = 6,  Descricao = "Pastelão", CadastradoEm = DateTime.Now },
                new Categoria { Id = 7,  Descricao = "Pastel Doce", CadastradoEm = DateTime.Now },
                new Categoria { Id = 8,  Descricao = "Cervejas", CadastradoEm = DateTime.Now },
                new Categoria { Id = 9,  Descricao = "Sucos", CadastradoEm = DateTime.Now },
                new Categoria { Id = 10, Descricao = "Refrigerante", CadastradoEm = DateTime.Now }
             });
        }
    }
}
