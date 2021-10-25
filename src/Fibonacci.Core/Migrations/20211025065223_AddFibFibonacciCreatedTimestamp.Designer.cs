﻿// <auto-generated />
using System;
using Fibonacci.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Fibonacci.Core.Migrations
{
    [DbContext(typeof(FibonacciDataContext))]
    [Migration("20211025065223_AddFibFibonacciCreatedTimestamp")]
    partial class AddFibFibonacciCreatedTimestamp
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0-rc.2.21480.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Fibonacci.Core.TFibonacci", b =>
                {
                    b.Property<Guid>("FibId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("FIB_Id")
                        .HasDefaultValueSql("(newid())");

                    b.Property<DateTime>("FibCreatedTimestamp")
                        .HasColumnType("datetime2")
                        .HasColumnName("FIB_Created_Timestamp");

                    b.Property<int>("FibInput")
                        .HasColumnType("int")
                        .HasColumnName("FIB_Input");

                    b.Property<long>("FibOutput")
                        .HasColumnType("bigint")
                        .HasColumnName("FIB_Output");

                    b.HasKey("FibId")
                        .HasName("PK_Fibonacci");

                    b.ToTable("T_Fibonacci", "sch_fib");
                });
#pragma warning restore 612, 618
        }
    }
}
