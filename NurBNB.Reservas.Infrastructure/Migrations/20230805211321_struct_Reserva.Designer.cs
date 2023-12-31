﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NurBNB.Reservas.Infrastructure.EF.Context;

#nullable disable

namespace NurBNB.Reservas.Infrastructure.Migrations
{
    [DbContext(typeof(ReadDbContext))]
    [Migration("20230805211321_struct_Reserva")]
    partial class structReserva
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.9");

            modelBuilder.Entity("NurBNB.Reservas.Infrastructure.EF.ReadModel.HuespedReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("huespedID");

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT")
                        .HasColumnName("apellidos");

                    b.Property<string>("Calle")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT")
                        .HasColumnName("calle");

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT")
                        .HasColumnName("ciudad");

                    b.Property<string>("Codigo_postal")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT")
                        .HasColumnName("codigo_postal");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT")
                        .HasColumnName("email");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT")
                        .HasColumnName("nombres");

                    b.Property<string>("NroDoc")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT")
                        .HasColumnName("nrodoc");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT")
                        .HasColumnName("pais");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT")
                        .HasColumnName("telefono");

                    b.HasKey("Id");

                    b.ToTable("huesped");
                });

            modelBuilder.Entity("NurBNB.Reservas.Infrastructure.EF.ReadModel.PropiedadReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("ID_Propiedad");

                    b.Property<string>("Detalle")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("TEXT")
                        .HasColumnName("detalle");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("estado");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("precio");

                    b.Property<string>("Propietario_ID")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Propietario_ID");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT")
                        .HasColumnName("titulo");

                    b.Property<string>("Ubicacion")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("TEXT")
                        .HasColumnName("ubicacion");

                    b.HasKey("Id");

                    b.ToTable("propiedad");
                });

            modelBuilder.Entity("NurBNB.Reservas.Infrastructure.EF.ReadModel.ReservaReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("ID_Reserva");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT")
                        .HasColumnName("Estado");

                    b.Property<DateTime>("FechaCheckIn")
                        .HasColumnType("TEXT")
                        .HasColumnName("FechaCheckin");

                    b.Property<DateTime>("FechaCheckOut")
                        .HasColumnType("TEXT")
                        .HasColumnName("FechaCheckOut");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("TEXT")
                        .HasColumnName("FechaRegistro");

                    b.Property<Guid>("HuespedID")
                        .HasColumnType("TEXT")
                        .HasColumnName("Huesped_ID");

                    b.Property<string>("Motivo")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("TEXT")
                        .HasColumnName("Motivo");

                    b.Property<Guid>("PropiedadID")
                        .HasColumnType("TEXT")
                        .HasColumnName("Propiedad_ID");

                    b.HasKey("Id");

                    b.ToTable("Reserva");
                });
#pragma warning restore 612, 618
        }
    }
}
