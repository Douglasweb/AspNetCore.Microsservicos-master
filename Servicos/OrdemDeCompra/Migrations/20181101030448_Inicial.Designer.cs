﻿// <auto-generated />
using CasaDoCodigo.OrdemDeCompra;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace OrdemDeCompra.API.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20181101030448_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CasaDoCodigo.OrdemDeCompra.Models.ItemPedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PedidoId");

                    b.Property<string>("ProdutoCodigo")
                        .IsRequired();

                    b.Property<int>("ProdutoId");

                    b.Property<string>("ProdutoNome")
                        .IsRequired();

                    b.Property<decimal>("ProdutoPreco");

                    b.Property<decimal>("ProdutoPrecoUnitario");

                    b.Property<int>("ProdutoQuantidade");

                    b.HasKey("Id");

                    b.HasIndex("PedidoId");

                    b.ToTable("ItemPedido");
                });

            modelBuilder.Entity("CasaDoCodigo.OrdemDeCompra.Models.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClienteBairro")
                        .IsRequired();

                    b.Property<string>("ClienteCEP")
                        .IsRequired();

                    b.Property<string>("ClienteComplemento")
                        .IsRequired();

                    b.Property<string>("ClienteEmail")
                        .IsRequired();

                    b.Property<string>("ClienteEndereco")
                        .IsRequired();

                    b.Property<string>("ClienteId")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("ClienteMunicipio")
                        .IsRequired();

                    b.Property<string>("ClienteNome")
                        .IsRequired();

                    b.Property<string>("ClienteTelefone")
                        .IsRequired();

                    b.Property<string>("ClienteUF")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("CasaDoCodigo.OrdemDeCompra.Models.ItemPedido", b =>
                {
                    b.HasOne("CasaDoCodigo.OrdemDeCompra.Models.Pedido", "Pedido")
                        .WithMany("Itens")
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
