using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Lanchonete.API.DataBase.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Caixas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descrição = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    DataAbertura = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataEncerramento = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caixas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CadastradoEm = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CaixaId = table.Column<int>(type: "int", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CadastradoEm = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pedidos_Caixas_CaixaId",
                        column: x => x.CaixaId,
                        principalTable: "Caixas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoriaId = table.Column<int>(type: "int", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CadastradoEm = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produtos_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ItensPedido",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PedidoId = table.Column<int>(type: "int", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false),
                    ProdutoId = table.Column<int>(type: "int", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CadastradoEm = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItensPedido", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItensPedido_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItensPedido_Pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItensPedido_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "Id", "CadastradoEm", "Descricao" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 27, 4, 27, 51, 265, DateTimeKind.Local).AddTicks(7763), "Bauru" },
                    { 2, new DateTime(2025, 4, 27, 4, 27, 51, 265, DateTimeKind.Local).AddTicks(7965), "Hambúrguer" },
                    { 3, new DateTime(2025, 4, 27, 4, 27, 51, 265, DateTimeKind.Local).AddTicks(7967), "Pastel Simples" },
                    { 4, new DateTime(2025, 4, 27, 4, 27, 51, 265, DateTimeKind.Local).AddTicks(7968), "Pastel Especial" },
                    { 5, new DateTime(2025, 4, 27, 4, 27, 51, 265, DateTimeKind.Local).AddTicks(7969), "Mini Pastel" },
                    { 6, new DateTime(2025, 4, 27, 4, 27, 51, 265, DateTimeKind.Local).AddTicks(7971), "Pastelão" },
                    { 7, new DateTime(2025, 4, 27, 4, 27, 51, 265, DateTimeKind.Local).AddTicks(7972), "Pastel Doce" },
                    { 8, new DateTime(2025, 4, 27, 4, 27, 51, 265, DateTimeKind.Local).AddTicks(7973), "Cervejas" },
                    { 9, new DateTime(2025, 4, 27, 4, 27, 51, 265, DateTimeKind.Local).AddTicks(7974), "Sucos" },
                    { 10, new DateTime(2025, 4, 27, 4, 27, 51, 265, DateTimeKind.Local).AddTicks(7976), "Refrigerante" }
                });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "CadastradoEm", "CategoriaId", "Descricao", "Valor" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(384), 1, "Carne Médio", 43.00m },
                    { 2, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(559), 1, "Carne Grande", 49.00m },
                    { 3, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(561), 1, "Pernil Médio", 37.00m },
                    { 4, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(563), 1, "Pernil Grande", 42.00m },
                    { 5, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(565), 1, "Frango Médio", 37.00m },
                    { 6, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(567), 1, "Frango Grande", 42.00m },
                    { 7, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(568), 1, "Linguiça Médio", 37.00m },
                    { 8, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(571), 1, "Linguiça Grande", 42.00m },
                    { 9, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(573), 1, "Calabresa Médio", 37.00m },
                    { 10, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(575), 1, "Calabresa Grande", 42.00m },
                    { 11, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(577), 1, "Mortadela Médio", 32.00m },
                    { 12, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(578), 1, "Mortadela Grande", 35.00m },
                    { 13, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(615), 1, "Presunto Médio", 32.00m },
                    { 14, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(617), 1, "Presunto Grande", 35.00m },
                    { 15, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(619), 1, "Adicional Queijo", 4.00m },
                    { 16, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(620), 1, "Adicional Ovo", 2.00m },
                    { 17, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(622), 1, "Adicional Bacon", 4.00m },
                    { 18, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(624), 1, "Adicional Cream Cheese", 5.00m },
                    { 19, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(625), 2, "X-Salada Hambúrguer", 23.00m },
                    { 20, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(627), 2, "X-Salada Francês", 25.00m },
                    { 21, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(628), 2, "X-Duplo Hambúrguer", 27.00m },
                    { 22, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(630), 2, "X-Duplo Francês", 29.00m },
                    { 23, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(632), 2, "X-Tudo Hambúrguer", 30.00m },
                    { 24, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(633), 2, "X-Tudo Francês", 32.00m },
                    { 25, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(635), 2, "X-Egg Hambúrguer", 23.00m },
                    { 26, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(637), 2, "X-Egg Francês", 25.00m },
                    { 27, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(638), 2, "X-Vegetariano Hambúrguer", 25.00m },
                    { 28, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(640), 2, "X-Vegetariano Francês", 27.00m },
                    { 29, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(655), 2, "X-Costela Hambúrguer", 27.00m },
                    { 30, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(657), 2, "X-Costela Francês", 29.00m },
                    { 31, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(658), 2, "X-Duplo Costela Hambúrguer", 33.00m },
                    { 32, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(660), 2, "X-Duplo Costela Francês", 35.00m },
                    { 33, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(662), 3, "Pastel Simples Carne", 12.00m },
                    { 34, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(663), 3, "Pastel Simples Queijo", 12.00m },
                    { 35, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(665), 3, "Pastel Simples Palmito", 12.00m },
                    { 36, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(666), 4, "Pastel Especial Atum", 19.00m },
                    { 37, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(668), 4, "Pastel Especial Brócolis", 19.00m },
                    { 38, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(670), 4, "Pastel Especial Carne Seca", 19.00m },
                    { 39, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(672), 4, "Pastel Especial Hambúrguer", 19.00m },
                    { 40, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(673), 4, "Pastel Especial Queijo", 19.00m },
                    { 41, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(675), 4, "Pastel Especial Hot Dog", 19.00m },
                    { 42, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(676), 5, "Mini Pastel 6 Unidades", 15.00m },
                    { 43, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(678), 5, "Mini Pastel 12 Unidades", 25.00m },
                    { 44, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(693), 6, "Pastelão Carne", 43.00m },
                    { 45, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(694), 6, "Pastelão Pernil", 43.00m },
                    { 46, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(696), 6, "Pastelão Frango", 43.00m },
                    { 47, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(697), 6, "Pastelão Calabresa", 43.00m },
                    { 48, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(699), 6, "Pastelão Brócolis", 38.00m },
                    { 49, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(701), 6, "Pastelão Pizza", 38.00m },
                    { 50, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(702), 7, "Pastel Doce Chocolate ao Leite", 12.00m },
                    { 51, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(704), 7, "Pastel Doce Chocolate Branco", 12.00m },
                    { 52, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(705), 7, "Pastel Doce Banana com Chocolate ao Leite", 12.00m },
                    { 53, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(707), 7, "Pastel Doce Banana com Chocolate Branco", 12.00m },
                    { 54, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(709), 7, "Pastel Doce Banana com Canela", 12.00m },
                    { 55, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(711), 7, "Pastel Doce Romeu e Julieta", 12.00m },
                    { 56, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(712), 7, "Pastel Doce Banana e Doce de Leite", 12.00m },
                    { 57, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(714), 8, "Cerveja Skol Lata", 5.00m },
                    { 58, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(716), 8, "Cerveja Skol Garrafa", 12.00m },
                    { 59, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(717), 8, "Cerveja Brahma Lata", 5.00m },
                    { 60, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(719), 8, "Cerveja Brahma Garrafa", 12.00m },
                    { 61, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(721), 8, "Cerveja Original Garrafa", 14.00m },
                    { 62, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(722), 8, "Cerveja Heineken Garrafa", 16.00m },
                    { 63, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(724), 9, "Suco Único", 10.00m },
                    { 64, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(726), 9, "Suco Adicional de Polpa", 4.00m },
                    { 65, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(727), 10, "Refrigerante KS", 4.00m },
                    { 66, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(729), 10, "Refrigerante Lata", 5.00m },
                    { 67, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(730), 10, "Refrigerante 600ml", 8.00m },
                    { 68, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(732), 10, "Fanta 2L", 15.00m },
                    { 69, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(734), 10, "Coca-Cola 2L", 15.00m },
                    { 70, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(735), 10, "Guaraná 2L", 13.00m },
                    { 71, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(747), 10, "Sprite 2L", 13.00m },
                    { 72, new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(749), 10, "Água Crystal 500ml", 4.00m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItensPedido_CategoriaId",
                table: "ItensPedido",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_ItensPedido_PedidoId",
                table: "ItensPedido",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_ItensPedido_ProdutoId",
                table: "ItensPedido",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_CaixaId",
                table: "Pedidos",
                column: "CaixaId");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_CategoriaId",
                table: "Produtos",
                column: "CategoriaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItensPedido");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Caixas");

            migrationBuilder.DropTable(
                name: "Categorias");
        }
    }
}
