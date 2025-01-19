﻿// <auto-generated />
using System;
using Construct_Planner_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Construct_Planner_API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250119204109_AddAgendamentoTimestampWithTimeZone")]
    partial class AddAgendamentoTimestampWithTimeZone
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Construct_Planner_API.Models.Agendamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataFimMontagem")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DataInicioConcretagem")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DataInicioFormas")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DataInicioMontagem")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DataInicioProjeto")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DataInicioTransporte")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("ObraId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ObraId");

                    b.ToTable("Agendamentos");
                });

            modelBuilder.Entity("Construct_Planner_API.Models.Obra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int>("Concreting")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Deadline")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Mold")
                        .HasColumnType("integer");

                    b.Property<int>("Mounting")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int>("Project")
                        .HasColumnType("integer");

                    b.Property<int>("Transport")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Obras");
                });

            modelBuilder.Entity("Construct_Planner_API.Models.Agendamento", b =>
                {
                    b.HasOne("Construct_Planner_API.Models.Obra", "Obra")
                        .WithMany()
                        .HasForeignKey("ObraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Obra");
                });
#pragma warning restore 612, 618
        }
    }
}
