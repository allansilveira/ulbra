﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using contaluz.Models;

namespace contaluz.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190927210901_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("contaluz.Models.Light", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("dataLeitura");

                    b.Property<DateTime>("dataPagamento");

                    b.Property<int>("kw");

                    b.Property<double>("media");

                    b.Property<int>("numeroLeitura");

                    b.Property<double>("valor");

                    b.HasKey("id");

                    b.ToTable("Conta");
                });
#pragma warning restore 612, 618
        }
    }
}