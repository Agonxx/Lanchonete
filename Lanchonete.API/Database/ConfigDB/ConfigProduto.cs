using Lanchonete.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lanchonete.API.Database.ConfigDB
{
    public class ConfigProduto : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasOne<Categoria>()
                .WithMany()
                .HasForeignKey(h => h.CategoriaId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasData(new Produto[]
             {
                // BAURU
                new Produto { Id = 1, CategoriaId = 1, Descricao = "Carne Médio", Valor = 43.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 2, CategoriaId = 1, Descricao = "Carne Grande", Valor = 49.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 3, CategoriaId = 1, Descricao = "Pernil Médio", Valor = 37.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 4, CategoriaId = 1, Descricao = "Pernil Grande", Valor = 42.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 5, CategoriaId = 1, Descricao = "Frango Médio", Valor = 37.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 6, CategoriaId = 1, Descricao = "Frango Grande", Valor = 42.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 7, CategoriaId = 1, Descricao = "Linguiça Médio", Valor = 37.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 8, CategoriaId = 1, Descricao = "Linguiça Grande", Valor = 42.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 9, CategoriaId = 1, Descricao = "Calabresa Médio", Valor = 37.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 10, CategoriaId = 1, Descricao = "Calabresa Grande", Valor = 42.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 11, CategoriaId = 1, Descricao = "Mortadela Médio", Valor = 32.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 12, CategoriaId = 1, Descricao = "Mortadela Grande", Valor = 35.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 13, CategoriaId = 1, Descricao = "Presunto Médio", Valor = 32.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 14, CategoriaId = 1, Descricao = "Presunto Grande", Valor = 35.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 15, CategoriaId = 1, Descricao = "Adicional Queijo", Valor = 4.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 16, CategoriaId = 1, Descricao = "Adicional Ovo", Valor = 2.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 17, CategoriaId = 1, Descricao = "Adicional Bacon", Valor = 4.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 18, CategoriaId = 1, Descricao = "Adicional Cream Cheese", Valor = 5.00m, CadastradoEm = DateTime.Now },

                // HAMBURGUER
                new Produto { Id = 19, CategoriaId = 2, Descricao = "X-Salada Hambúrguer", Valor = 23.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 20, CategoriaId = 2, Descricao = "X-Salada Francês", Valor = 25.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 21, CategoriaId = 2, Descricao = "X-Duplo Hambúrguer", Valor = 27.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 22, CategoriaId = 2, Descricao = "X-Duplo Francês", Valor = 29.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 23, CategoriaId = 2, Descricao = "X-Tudo Hambúrguer", Valor = 30.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 24, CategoriaId = 2, Descricao = "X-Tudo Francês", Valor = 32.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 25, CategoriaId = 2, Descricao = "X-Egg Hambúrguer", Valor = 23.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 26, CategoriaId = 2, Descricao = "X-Egg Francês", Valor = 25.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 27, CategoriaId = 2, Descricao = "X-Vegetariano Hambúrguer", Valor = 25.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 28, CategoriaId = 2, Descricao = "X-Vegetariano Francês", Valor = 27.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 29, CategoriaId = 2, Descricao = "X-Costela Hambúrguer", Valor = 27.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 30, CategoriaId = 2, Descricao = "X-Costela Francês", Valor = 29.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 31, CategoriaId = 2, Descricao = "X-Duplo Costela Hambúrguer", Valor = 33.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 32, CategoriaId = 2, Descricao = "X-Duplo Costela Francês", Valor = 35.00m, CadastradoEm = DateTime.Now },

                // PASTEL SIMPLES
                new Produto { Id = 33, CategoriaId = 3, Descricao = "Pastel Simples Carne", Valor = 12.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 34, CategoriaId = 3, Descricao = "Pastel Simples Queijo", Valor = 12.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 35, CategoriaId = 3, Descricao = "Pastel Simples Palmito", Valor = 12.00m, CadastradoEm = DateTime.Now },

                // PASTEL ESPECIAL
                new Produto { Id = 36, CategoriaId = 4, Descricao = "Pastel Especial Atum", Valor = 19.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 37, CategoriaId = 4, Descricao = "Pastel Especial Brócolis", Valor = 19.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 38, CategoriaId = 4, Descricao = "Pastel Especial Carne Seca", Valor = 19.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 39, CategoriaId = 4, Descricao = "Pastel Especial Hambúrguer", Valor = 19.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 40, CategoriaId = 4, Descricao = "Pastel Especial Queijo", Valor = 19.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 41, CategoriaId = 4, Descricao = "Pastel Especial Hot Dog", Valor = 19.00m, CadastradoEm = DateTime.Now },

                // MINI PASTEL
                new Produto { Id = 42, CategoriaId = 5, Descricao = "Mini Pastel 6 Unidades", Valor = 15.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 43, CategoriaId = 5, Descricao = "Mini Pastel 12 Unidades", Valor = 25.00m, CadastradoEm = DateTime.Now },

                // PASTELÃO
                new Produto { Id = 44, CategoriaId = 6, Descricao = "Pastelão Carne", Valor = 43.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 45, CategoriaId = 6, Descricao = "Pastelão Pernil", Valor = 43.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 46, CategoriaId = 6, Descricao = "Pastelão Frango", Valor = 43.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 47, CategoriaId = 6, Descricao = "Pastelão Calabresa", Valor = 43.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 48, CategoriaId = 6, Descricao = "Pastelão Brócolis", Valor = 38.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 49, CategoriaId = 6, Descricao = "Pastelão Pizza", Valor = 38.00m, CadastradoEm = DateTime.Now },

                // PASTEL DOCE
                new Produto { Id = 50, CategoriaId = 7, Descricao = "Pastel Doce Chocolate ao Leite", Valor = 12.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 51, CategoriaId = 7, Descricao = "Pastel Doce Chocolate Branco", Valor = 12.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 52, CategoriaId = 7, Descricao = "Pastel Doce Banana com Chocolate ao Leite", Valor = 12.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 53, CategoriaId = 7, Descricao = "Pastel Doce Banana com Chocolate Branco", Valor = 12.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 54, CategoriaId = 7, Descricao = "Pastel Doce Banana com Canela", Valor = 12.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 55, CategoriaId = 7, Descricao = "Pastel Doce Romeu e Julieta", Valor = 12.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 56, CategoriaId = 7, Descricao = "Pastel Doce Banana e Doce de Leite", Valor = 12.00m, CadastradoEm = DateTime.Now },

                // CERVEJAS
                new Produto { Id = 57, CategoriaId = 8, Descricao = "Cerveja Skol Lata", Valor = 5.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 58, CategoriaId = 8, Descricao = "Cerveja Skol Garrafa", Valor = 12.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 59, CategoriaId = 8, Descricao = "Cerveja Brahma Lata", Valor = 5.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 60, CategoriaId = 8, Descricao = "Cerveja Brahma Garrafa", Valor = 12.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 61, CategoriaId = 8, Descricao = "Cerveja Original Garrafa", Valor = 14.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 62, CategoriaId = 8, Descricao = "Cerveja Heineken Garrafa", Valor = 16.00m, CadastradoEm = DateTime.Now },

                // SUCOS 
                new Produto { Id = 63, CategoriaId = 9, Descricao = "Suco Único", Valor = 10.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 64, CategoriaId = 9, Descricao = "Suco Adicional de Polpa", Valor = 4.00m, CadastradoEm = DateTime.Now },

                // REFRIGERANTE 
                new Produto { Id = 65, CategoriaId = 10, Descricao = "Refrigerante KS", Valor = 4.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 66, CategoriaId = 10, Descricao = "Refrigerante Lata", Valor = 5.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 67, CategoriaId = 10, Descricao = "Refrigerante 600ml", Valor = 8.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 68, CategoriaId = 10, Descricao = "Fanta 2L", Valor = 15.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 69, CategoriaId = 10, Descricao = "Coca-Cola 2L", Valor = 15.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 70, CategoriaId = 10, Descricao = "Guaraná 2L", Valor = 13.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 71, CategoriaId = 10, Descricao = "Sprite 2L", Valor = 13.00m, CadastradoEm = DateTime.Now },
                new Produto { Id = 72, CategoriaId = 10, Descricao = "Água Crystal 500ml", Valor = 4.00m, CadastradoEm = DateTime.Now },
             });
        }
    }
}
