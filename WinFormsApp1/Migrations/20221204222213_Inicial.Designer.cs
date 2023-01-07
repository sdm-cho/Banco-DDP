﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WinFormsApp1;

#nullable disable

namespace WinFormsApp1.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20221204222213_Inicial")]
    partial class Inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WinFormsApp1.CajaDeAhorro", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Cbu")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<double>("saldo")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.ToTable("Cajas", (string)null);
                });

            modelBuilder.Entity("WinFormsApp1.Movimiento", b =>
                {
                    b.Property<int>("idm")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idm"));

                    b.Property<string>("detalle")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("date");

                    b.Property<int>("id")
                        .HasColumnType("int");

                    b.Property<double>("monto")
                        .HasColumnType("float");

                    b.HasKey("idm");

                    b.HasIndex("id");

                    b.ToTable("Movimientos", (string)null);
                });

            modelBuilder.Entity("WinFormsApp1.Pago", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("metodo")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<double>("monto")
                        .HasColumnType("float");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int>("num_usr")
                        .HasColumnType("int");

                    b.Property<bool>("pagado")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.HasIndex("num_usr");

                    b.ToTable("Pagos", (string)null);
                });

            modelBuilder.Entity("WinFormsApp1.PlazoFijo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("fechaFin")
                        .HasColumnType("date");

                    b.Property<DateTime>("fechaIni")
                        .HasColumnType("date");

                    b.Property<double>("monto")
                        .HasColumnType("float");

                    b.Property<int>("num_usr")
                        .HasColumnType("int");

                    b.Property<bool>("pagado")
                        .HasColumnType("bit");

                    b.Property<double>("tasa")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.HasIndex("num_usr");

                    b.ToTable("Plazos", (string)null);
                });

            modelBuilder.Entity("WinFormsApp1.Tarjeta", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("codigoV")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<double>("consumos")
                        .HasColumnType("float");

                    b.Property<double>("limite")
                        .HasColumnType("float");

                    b.Property<int>("num_usr")
                        .HasColumnType("int");

                    b.Property<string>("numero")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("id");

                    b.HasIndex("num_usr");

                    b.ToTable("Tarjetas", (string)null);
                });

            modelBuilder.Entity("WinFormsApp1.Usuario", b =>
                {
                    b.Property<int>("num_usr")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("num_usr"));

                    b.Property<string>("apellido")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("bloqueado")
                        .HasColumnType("bit");

                    b.Property<int>("dni")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<bool>("esADM")
                        .HasColumnType("bit");

                    b.Property<int>("intentosFallidos")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("num_usr");

                    b.ToTable("Usuarios", (string)null);

                    b.HasData(
                        new
                        {
                            numusr = 1,
                            apellido = "222",
                            bloqueado = false,
                            dni = 1234,
                            email = "111@111",
                            esADM = true,
                            intentosFallidos = 0,
                            nombre = "111",
                            password = "111"
                        },
                        new
                        {
                            numusr = 2,
                            apellido = "sda",
                            bloqueado = false,
                            dni = 1235,
                            email = "222@111",
                            esADM = false,
                            intentosFallidos = 0,
                            nombre = "asd",
                            password = "111"
                        },
                        new
                        {
                            numusr = 3,
                            apellido = "dsa",
                            bloqueado = false,
                            dni = 1236,
                            email = "333@111",
                            esADM = true,
                            intentosFallidos = 0,
                            nombre = "asd",
                            password = "111"
                        },
                        new
                        {
                            numusr = 4,
                            apellido = "ads",
                            bloqueado = true,
                            dni = 1237,
                            email = "444@111",
                            esADM = false,
                            intentosFallidos = 3,
                            nombre = "asd",
                            password = "111"
                        });
                });

            modelBuilder.Entity("WinFormsApp1.UsuarioCaja", b =>
                {
                    b.Property<int>("num_usr")
                        .HasColumnType("int");

                    b.Property<int>("id")
                        .HasColumnType("int");

                    b.HasKey("num_usr", "id");

                    b.HasIndex("id");

                    b.ToTable("UsuarioCaja");
                });

            modelBuilder.Entity("WinFormsApp1.Movimiento", b =>
                {
                    b.HasOne("WinFormsApp1.CajaDeAhorro", "caja")
                        .WithMany("misMovimientos")
                        .HasForeignKey("id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("caja");
                });

            modelBuilder.Entity("WinFormsApp1.Pago", b =>
                {
                    b.HasOne("WinFormsApp1.Usuario", "user")
                        .WithMany("misPagos")
                        .HasForeignKey("num_usr")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("user");
                });

            modelBuilder.Entity("WinFormsApp1.PlazoFijo", b =>
                {
                    b.HasOne("WinFormsApp1.Usuario", "user")
                        .WithMany("misPlazosFijos")
                        .HasForeignKey("num_usr")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("user");
                });

            modelBuilder.Entity("WinFormsApp1.Tarjeta", b =>
                {
                    b.HasOne("WinFormsApp1.Usuario", "user")
                        .WithMany("misTarjetas")
                        .HasForeignKey("num_usr")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("user");
                });

            modelBuilder.Entity("WinFormsApp1.UsuarioCaja", b =>
                {
                    b.HasOne("WinFormsApp1.CajaDeAhorro", "caja")
                        .WithMany("UserCaja")
                        .HasForeignKey("id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WinFormsApp1.Usuario", "user")
                        .WithMany("UserCaja")
                        .HasForeignKey("num_usr")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("caja");

                    b.Navigation("user");
                });

            modelBuilder.Entity("WinFormsApp1.CajaDeAhorro", b =>
                {
                    b.Navigation("UserCaja");

                    b.Navigation("misMovimientos");
                });

            modelBuilder.Entity("WinFormsApp1.Usuario", b =>
                {
                    b.Navigation("UserCaja");

                    b.Navigation("misPagos");

                    b.Navigation("misPlazosFijos");

                    b.Navigation("misTarjetas");
                });
#pragma warning restore 612, 618
        }
    }
}