﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReservaDeHotel.Data;

#nullable disable

namespace ReservaDeHotel.Migrations
{
    [DbContext(typeof(HotelDbContext))]
    [Migration("20231004192618_ba")]
    partial class ba
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("ReservaDeHotel.Models.Avaliacao", b =>
                {
                    b.Property<int>("IdAvaliacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AvaliacaoEstrelas")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Comentario")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataAvaliacao")
                        .HasColumnType("TEXT");

                    b.Property<int>("IdHotel")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdAvaliacao");

                    b.ToTable("Avaliacao");
                });

            modelBuilder.Entity("ReservaDeHotel.Models.Cidade", b =>
                {
                    b.Property<int>("IdCidade")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Estado")
                        .HasColumnType("TEXT");

                    b.Property<string>("ListaHoteis")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("País")
                        .HasColumnType("TEXT");

                    b.HasKey("IdCidade");

                    b.ToTable("Cidade");
                });

            modelBuilder.Entity("ReservaDeHotel.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Login")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<int>("NumeroTelefone")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Senha")
                        .HasColumnType("TEXT");

                    b.HasKey("ClienteId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("ReservaDeHotel.Models.Comodidade", b =>
                {
                    b.Property<int>("IDComodidade")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Disponibilidade")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IDHotel")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NumeroDoQuarto")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("PrecoPorNoite")
                        .HasColumnType("decimal(6,2)");

                    b.Property<string>("TipoDeQuarto")
                        .HasColumnType("TEXT");

                    b.HasKey("IDComodidade");

                    b.ToTable("Comodidade");
                });

            modelBuilder.Entity("ReservaDeHotel.Models.Dono", b =>
                {
                    b.Property<int>("DonoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Login")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<int>("NumeroTelefone")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Senha")
                        .HasColumnType("TEXT");

                    b.HasKey("DonoId");

                    b.ToTable("Dono");
                });

            modelBuilder.Entity("ReservaDeHotel.Models.Hotel", b =>
                {
                    b.Property<int>("IDHotel")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("AvaliacaoMedia")
                        .HasColumnType("REAL");

                    b.Property<int>("Classificacao")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<int?>("DonoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Endereco")
                        .HasColumnType("TEXT");

                    b.Property<int>("IdDoDono")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ListaDeQuartos")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<int>("NumeroDeQuartosDisponiveis")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NumeroTotalDeQuartos")
                        .HasColumnType("INTEGER");

                    b.HasKey("IDHotel");

                    b.HasIndex("DonoId");

                    b.ToTable("Hotel");
                });

            modelBuilder.Entity("ReservaDeHotel.Models.Pagamento", b =>
                {
                    b.Property<int>("IdPagamento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataPagamento")
                        .HasColumnType("TEXT");

                    b.Property<int>("IdReservaEstadia")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MetodoPagamento")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Valor")
                        .HasColumnType("TEXT");

                    b.HasKey("IdPagamento");

                    b.ToTable("Pagamento");
                });

            modelBuilder.Entity("ReservaDeHotel.Models.Hotel", b =>
                {
                    b.HasOne("ReservaDeHotel.Models.Dono", null)
                        .WithMany("ListaHoteis")
                        .HasForeignKey("DonoId");
                });

            modelBuilder.Entity("ReservaDeHotel.Models.Dono", b =>
                {
                    b.Navigation("ListaHoteis");
                });
#pragma warning restore 612, 618
        }
    }
}
