﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReservaDeHotel.Data;

#nullable disable

namespace ReservaDeHotel.Migrations
{
    [DbContext(typeof(HotelDbContext))]
    [Migration("20230929180426_primeiraMigracao")]
    partial class primeiraMigracao
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

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
#pragma warning restore 612, 618
        }
    }
}
