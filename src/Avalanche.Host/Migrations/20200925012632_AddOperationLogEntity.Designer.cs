﻿// <auto-generated />
using System;
using Avalanche.Host.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Avalanche.Host.Migrations
{
    [DbContext(typeof(AvalancheDbContext))]
    [Migration("20200925012632_AddOperationLogEntity")]
    partial class AddOperationLogEntity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Avalanche.Host.Models.MobileNumber", b =>
                {
                    b.Property<string>("Msisdn")
                        .HasColumnName("MOBILENUMBER")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.ToTable("m912");
                });

            modelBuilder.Entity("Avalanche.Host.Models.OperationLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrokerResponse")
                        .IsRequired()
                        .HasColumnType("nvarchar(1024)");

                    b.Property<string>("Msisdn")
                        .IsRequired()
                        .HasColumnType("varchar(11)");

                    b.Property<DateTime>("SentDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(512)");

                    b.HasKey("Id");

                    b.ToTable("OperationLogs");
                });
#pragma warning restore 612, 618
        }
    }
}