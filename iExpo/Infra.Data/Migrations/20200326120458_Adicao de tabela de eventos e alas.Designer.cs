﻿// <auto-generated />
using System;
using Infra.Data.Contextos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infra.Data.Migrations
{
    [DbContext(typeof(iExpoContext))]
    [Migration("20200326120458_Adicao de tabela de eventos e alas")]
    partial class Adicaodetabeladeeventosealas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Dominios.Classes.Alas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnName("Descricao")
                        .HasColumnType("varchar(255)");

                    b.Property<int?>("EventoId");

                    b.Property<int>("IdEvento")
                        .HasColumnName("IdEvento")
                        .HasColumnType("int");

                    b.Property<int>("IdSensor")
                        .HasColumnName("IdSensor")
                        .HasColumnType("int");

                    b.Property<int?>("SensorId");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnName("Titulo")
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("EventoId");

                    b.HasIndex("SensorId");

                    b.ToTable("Alas");
                });

            modelBuilder.Entity("Dominios.Classes.Eventos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataFim")
                        .HasColumnName("DataFim")
                        .HasColumnType("date");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnName("DataInicio")
                        .HasColumnType("date");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnName("Endereco")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("Nome")
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Eventos");
                });

            modelBuilder.Entity("Dominios.Classes.Sensores", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Codigo")
                        .HasColumnName("Codigo")
                        .HasColumnType("int");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnName("Modelo")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnName("Status")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Texto")
                        .IsRequired()
                        .HasColumnName("Texto")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnName("Titulo")
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Sensores");
                });

            modelBuilder.Entity("Dominios.Classes.Usuarios", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("Email")
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Nome")
                        .HasColumnName("Nome")
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnName("Senha")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(24);

                    b.HasKey("Id");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new { Id = 1, Email = "admin@iexpo.com", Senha = "iexpo132" }
                    );
                });

            modelBuilder.Entity("Dominios.Classes.Alas", b =>
                {
                    b.HasOne("Dominios.Classes.Eventos", "Evento")
                        .WithMany()
                        .HasForeignKey("EventoId");

                    b.HasOne("Dominios.Classes.Sensores", "Sensor")
                        .WithMany()
                        .HasForeignKey("SensorId");
                });
#pragma warning restore 612, 618
        }
    }
}
