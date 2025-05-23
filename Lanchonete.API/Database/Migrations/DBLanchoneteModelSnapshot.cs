﻿// <auto-generated />
using System;
using Lanchonete.API.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Lanchonete.API.DataBase.Migrations
{
    [DbContext(typeof(DBLanchonete))]
    partial class DBLanchoneteModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Lanchonete.Shared.Models.Caixa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataAbertura")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataEncerramento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descrição")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Caixas");
                });

            modelBuilder.Entity("Lanchonete.Shared.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CadastradoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categorias");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 265, DateTimeKind.Local).AddTicks(7763),
                            Descricao = "Bauru"
                        },
                        new
                        {
                            Id = 2,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 265, DateTimeKind.Local).AddTicks(7965),
                            Descricao = "Hambúrguer"
                        },
                        new
                        {
                            Id = 3,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 265, DateTimeKind.Local).AddTicks(7967),
                            Descricao = "Pastel Simples"
                        },
                        new
                        {
                            Id = 4,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 265, DateTimeKind.Local).AddTicks(7968),
                            Descricao = "Pastel Especial"
                        },
                        new
                        {
                            Id = 5,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 265, DateTimeKind.Local).AddTicks(7969),
                            Descricao = "Mini Pastel"
                        },
                        new
                        {
                            Id = 6,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 265, DateTimeKind.Local).AddTicks(7971),
                            Descricao = "Pastelão"
                        },
                        new
                        {
                            Id = 7,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 265, DateTimeKind.Local).AddTicks(7972),
                            Descricao = "Pastel Doce"
                        },
                        new
                        {
                            Id = 8,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 265, DateTimeKind.Local).AddTicks(7973),
                            Descricao = "Cervejas"
                        },
                        new
                        {
                            Id = 9,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 265, DateTimeKind.Local).AddTicks(7974),
                            Descricao = "Sucos"
                        },
                        new
                        {
                            Id = 10,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 265, DateTimeKind.Local).AddTicks(7976),
                            Descricao = "Refrigerante"
                        });
                });

            modelBuilder.Entity("Lanchonete.Shared.Models.ItemPedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CadastradoEm")
                        .HasColumnType("datetime2");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PedidoId")
                        .HasColumnType("int");

                    b.Property<int?>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("PedidoId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("ItensPedido");
                });

            modelBuilder.Entity("Lanchonete.Shared.Models.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CadastradoEm")
                        .HasColumnType("datetime2");

                    b.Property<int>("CaixaId")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CaixaId");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("Lanchonete.Shared.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CadastradoEm")
                        .HasColumnType("datetime2");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Produtos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(384),
                            CategoriaId = 1,
                            Descricao = "Carne Médio",
                            Valor = 43.00m
                        },
                        new
                        {
                            Id = 2,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(559),
                            CategoriaId = 1,
                            Descricao = "Carne Grande",
                            Valor = 49.00m
                        },
                        new
                        {
                            Id = 3,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(561),
                            CategoriaId = 1,
                            Descricao = "Pernil Médio",
                            Valor = 37.00m
                        },
                        new
                        {
                            Id = 4,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(563),
                            CategoriaId = 1,
                            Descricao = "Pernil Grande",
                            Valor = 42.00m
                        },
                        new
                        {
                            Id = 5,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(565),
                            CategoriaId = 1,
                            Descricao = "Frango Médio",
                            Valor = 37.00m
                        },
                        new
                        {
                            Id = 6,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(567),
                            CategoriaId = 1,
                            Descricao = "Frango Grande",
                            Valor = 42.00m
                        },
                        new
                        {
                            Id = 7,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(568),
                            CategoriaId = 1,
                            Descricao = "Linguiça Médio",
                            Valor = 37.00m
                        },
                        new
                        {
                            Id = 8,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(571),
                            CategoriaId = 1,
                            Descricao = "Linguiça Grande",
                            Valor = 42.00m
                        },
                        new
                        {
                            Id = 9,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(573),
                            CategoriaId = 1,
                            Descricao = "Calabresa Médio",
                            Valor = 37.00m
                        },
                        new
                        {
                            Id = 10,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(575),
                            CategoriaId = 1,
                            Descricao = "Calabresa Grande",
                            Valor = 42.00m
                        },
                        new
                        {
                            Id = 11,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(577),
                            CategoriaId = 1,
                            Descricao = "Mortadela Médio",
                            Valor = 32.00m
                        },
                        new
                        {
                            Id = 12,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(578),
                            CategoriaId = 1,
                            Descricao = "Mortadela Grande",
                            Valor = 35.00m
                        },
                        new
                        {
                            Id = 13,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(615),
                            CategoriaId = 1,
                            Descricao = "Presunto Médio",
                            Valor = 32.00m
                        },
                        new
                        {
                            Id = 14,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(617),
                            CategoriaId = 1,
                            Descricao = "Presunto Grande",
                            Valor = 35.00m
                        },
                        new
                        {
                            Id = 15,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(619),
                            CategoriaId = 1,
                            Descricao = "Adicional Queijo",
                            Valor = 4.00m
                        },
                        new
                        {
                            Id = 16,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(620),
                            CategoriaId = 1,
                            Descricao = "Adicional Ovo",
                            Valor = 2.00m
                        },
                        new
                        {
                            Id = 17,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(622),
                            CategoriaId = 1,
                            Descricao = "Adicional Bacon",
                            Valor = 4.00m
                        },
                        new
                        {
                            Id = 18,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(624),
                            CategoriaId = 1,
                            Descricao = "Adicional Cream Cheese",
                            Valor = 5.00m
                        },
                        new
                        {
                            Id = 19,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(625),
                            CategoriaId = 2,
                            Descricao = "X-Salada Hambúrguer",
                            Valor = 23.00m
                        },
                        new
                        {
                            Id = 20,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(627),
                            CategoriaId = 2,
                            Descricao = "X-Salada Francês",
                            Valor = 25.00m
                        },
                        new
                        {
                            Id = 21,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(628),
                            CategoriaId = 2,
                            Descricao = "X-Duplo Hambúrguer",
                            Valor = 27.00m
                        },
                        new
                        {
                            Id = 22,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(630),
                            CategoriaId = 2,
                            Descricao = "X-Duplo Francês",
                            Valor = 29.00m
                        },
                        new
                        {
                            Id = 23,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(632),
                            CategoriaId = 2,
                            Descricao = "X-Tudo Hambúrguer",
                            Valor = 30.00m
                        },
                        new
                        {
                            Id = 24,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(633),
                            CategoriaId = 2,
                            Descricao = "X-Tudo Francês",
                            Valor = 32.00m
                        },
                        new
                        {
                            Id = 25,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(635),
                            CategoriaId = 2,
                            Descricao = "X-Egg Hambúrguer",
                            Valor = 23.00m
                        },
                        new
                        {
                            Id = 26,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(637),
                            CategoriaId = 2,
                            Descricao = "X-Egg Francês",
                            Valor = 25.00m
                        },
                        new
                        {
                            Id = 27,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(638),
                            CategoriaId = 2,
                            Descricao = "X-Vegetariano Hambúrguer",
                            Valor = 25.00m
                        },
                        new
                        {
                            Id = 28,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(640),
                            CategoriaId = 2,
                            Descricao = "X-Vegetariano Francês",
                            Valor = 27.00m
                        },
                        new
                        {
                            Id = 29,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(655),
                            CategoriaId = 2,
                            Descricao = "X-Costela Hambúrguer",
                            Valor = 27.00m
                        },
                        new
                        {
                            Id = 30,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(657),
                            CategoriaId = 2,
                            Descricao = "X-Costela Francês",
                            Valor = 29.00m
                        },
                        new
                        {
                            Id = 31,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(658),
                            CategoriaId = 2,
                            Descricao = "X-Duplo Costela Hambúrguer",
                            Valor = 33.00m
                        },
                        new
                        {
                            Id = 32,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(660),
                            CategoriaId = 2,
                            Descricao = "X-Duplo Costela Francês",
                            Valor = 35.00m
                        },
                        new
                        {
                            Id = 33,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(662),
                            CategoriaId = 3,
                            Descricao = "Pastel Simples Carne",
                            Valor = 12.00m
                        },
                        new
                        {
                            Id = 34,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(663),
                            CategoriaId = 3,
                            Descricao = "Pastel Simples Queijo",
                            Valor = 12.00m
                        },
                        new
                        {
                            Id = 35,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(665),
                            CategoriaId = 3,
                            Descricao = "Pastel Simples Palmito",
                            Valor = 12.00m
                        },
                        new
                        {
                            Id = 36,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(666),
                            CategoriaId = 4,
                            Descricao = "Pastel Especial Atum",
                            Valor = 19.00m
                        },
                        new
                        {
                            Id = 37,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(668),
                            CategoriaId = 4,
                            Descricao = "Pastel Especial Brócolis",
                            Valor = 19.00m
                        },
                        new
                        {
                            Id = 38,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(670),
                            CategoriaId = 4,
                            Descricao = "Pastel Especial Carne Seca",
                            Valor = 19.00m
                        },
                        new
                        {
                            Id = 39,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(672),
                            CategoriaId = 4,
                            Descricao = "Pastel Especial Hambúrguer",
                            Valor = 19.00m
                        },
                        new
                        {
                            Id = 40,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(673),
                            CategoriaId = 4,
                            Descricao = "Pastel Especial Queijo",
                            Valor = 19.00m
                        },
                        new
                        {
                            Id = 41,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(675),
                            CategoriaId = 4,
                            Descricao = "Pastel Especial Hot Dog",
                            Valor = 19.00m
                        },
                        new
                        {
                            Id = 42,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(676),
                            CategoriaId = 5,
                            Descricao = "Mini Pastel 6 Unidades",
                            Valor = 15.00m
                        },
                        new
                        {
                            Id = 43,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(678),
                            CategoriaId = 5,
                            Descricao = "Mini Pastel 12 Unidades",
                            Valor = 25.00m
                        },
                        new
                        {
                            Id = 44,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(693),
                            CategoriaId = 6,
                            Descricao = "Pastelão Carne",
                            Valor = 43.00m
                        },
                        new
                        {
                            Id = 45,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(694),
                            CategoriaId = 6,
                            Descricao = "Pastelão Pernil",
                            Valor = 43.00m
                        },
                        new
                        {
                            Id = 46,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(696),
                            CategoriaId = 6,
                            Descricao = "Pastelão Frango",
                            Valor = 43.00m
                        },
                        new
                        {
                            Id = 47,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(697),
                            CategoriaId = 6,
                            Descricao = "Pastelão Calabresa",
                            Valor = 43.00m
                        },
                        new
                        {
                            Id = 48,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(699),
                            CategoriaId = 6,
                            Descricao = "Pastelão Brócolis",
                            Valor = 38.00m
                        },
                        new
                        {
                            Id = 49,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(701),
                            CategoriaId = 6,
                            Descricao = "Pastelão Pizza",
                            Valor = 38.00m
                        },
                        new
                        {
                            Id = 50,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(702),
                            CategoriaId = 7,
                            Descricao = "Pastel Doce Chocolate ao Leite",
                            Valor = 12.00m
                        },
                        new
                        {
                            Id = 51,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(704),
                            CategoriaId = 7,
                            Descricao = "Pastel Doce Chocolate Branco",
                            Valor = 12.00m
                        },
                        new
                        {
                            Id = 52,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(705),
                            CategoriaId = 7,
                            Descricao = "Pastel Doce Banana com Chocolate ao Leite",
                            Valor = 12.00m
                        },
                        new
                        {
                            Id = 53,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(707),
                            CategoriaId = 7,
                            Descricao = "Pastel Doce Banana com Chocolate Branco",
                            Valor = 12.00m
                        },
                        new
                        {
                            Id = 54,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(709),
                            CategoriaId = 7,
                            Descricao = "Pastel Doce Banana com Canela",
                            Valor = 12.00m
                        },
                        new
                        {
                            Id = 55,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(711),
                            CategoriaId = 7,
                            Descricao = "Pastel Doce Romeu e Julieta",
                            Valor = 12.00m
                        },
                        new
                        {
                            Id = 56,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(712),
                            CategoriaId = 7,
                            Descricao = "Pastel Doce Banana e Doce de Leite",
                            Valor = 12.00m
                        },
                        new
                        {
                            Id = 57,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(714),
                            CategoriaId = 8,
                            Descricao = "Cerveja Skol Lata",
                            Valor = 5.00m
                        },
                        new
                        {
                            Id = 58,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(716),
                            CategoriaId = 8,
                            Descricao = "Cerveja Skol Garrafa",
                            Valor = 12.00m
                        },
                        new
                        {
                            Id = 59,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(717),
                            CategoriaId = 8,
                            Descricao = "Cerveja Brahma Lata",
                            Valor = 5.00m
                        },
                        new
                        {
                            Id = 60,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(719),
                            CategoriaId = 8,
                            Descricao = "Cerveja Brahma Garrafa",
                            Valor = 12.00m
                        },
                        new
                        {
                            Id = 61,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(721),
                            CategoriaId = 8,
                            Descricao = "Cerveja Original Garrafa",
                            Valor = 14.00m
                        },
                        new
                        {
                            Id = 62,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(722),
                            CategoriaId = 8,
                            Descricao = "Cerveja Heineken Garrafa",
                            Valor = 16.00m
                        },
                        new
                        {
                            Id = 63,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(724),
                            CategoriaId = 9,
                            Descricao = "Suco Único",
                            Valor = 10.00m
                        },
                        new
                        {
                            Id = 64,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(726),
                            CategoriaId = 9,
                            Descricao = "Suco Adicional de Polpa",
                            Valor = 4.00m
                        },
                        new
                        {
                            Id = 65,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(727),
                            CategoriaId = 10,
                            Descricao = "Refrigerante KS",
                            Valor = 4.00m
                        },
                        new
                        {
                            Id = 66,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(729),
                            CategoriaId = 10,
                            Descricao = "Refrigerante Lata",
                            Valor = 5.00m
                        },
                        new
                        {
                            Id = 67,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(730),
                            CategoriaId = 10,
                            Descricao = "Refrigerante 600ml",
                            Valor = 8.00m
                        },
                        new
                        {
                            Id = 68,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(732),
                            CategoriaId = 10,
                            Descricao = "Fanta 2L",
                            Valor = 15.00m
                        },
                        new
                        {
                            Id = 69,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(734),
                            CategoriaId = 10,
                            Descricao = "Coca-Cola 2L",
                            Valor = 15.00m
                        },
                        new
                        {
                            Id = 70,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(735),
                            CategoriaId = 10,
                            Descricao = "Guaraná 2L",
                            Valor = 13.00m
                        },
                        new
                        {
                            Id = 71,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(747),
                            CategoriaId = 10,
                            Descricao = "Sprite 2L",
                            Valor = 13.00m
                        },
                        new
                        {
                            Id = 72,
                            CadastradoEm = new DateTime(2025, 4, 27, 4, 27, 51, 320, DateTimeKind.Local).AddTicks(749),
                            CategoriaId = 10,
                            Descricao = "Água Crystal 500ml",
                            Valor = 4.00m
                        });
                });

            modelBuilder.Entity("Lanchonete.Shared.Models.ItemPedido", b =>
                {
                    b.HasOne("Lanchonete.Shared.Models.Categoria", null)
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Lanchonete.Shared.Models.Pedido", null)
                        .WithMany()
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Lanchonete.Shared.Models.Produto", null)
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.NoAction);
                });

            modelBuilder.Entity("Lanchonete.Shared.Models.Pedido", b =>
                {
                    b.HasOne("Lanchonete.Shared.Models.Caixa", null)
                        .WithMany()
                        .HasForeignKey("CaixaId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Lanchonete.Shared.Models.Produto", b =>
                {
                    b.HasOne("Lanchonete.Shared.Models.Categoria", null)
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
