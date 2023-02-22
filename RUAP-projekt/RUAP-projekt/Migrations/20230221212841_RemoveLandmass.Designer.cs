﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RUAP_projekt.Data;

#nullable disable

namespace RUAP_projekt.Migrations
{
    [DbContext(typeof(FlagsDbContext))]
    [Migration("20230221212841_RemoveLandmass")]
    partial class RemoveLandmass
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RUAP_projekt.Models.Entities.Flag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Animate")
                        .HasColumnType("int");

                    b.Property<int?>("Bars")
                        .HasColumnType("int");

                    b.Property<int?>("Black")
                        .HasColumnType("int");

                    b.Property<int?>("Blue")
                        .HasColumnType("int");

                    b.Property<string>("BotRight")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Circles")
                        .HasColumnType("int");

                    b.Property<int?>("Colours")
                        .HasColumnType("int");

                    b.Property<int?>("Crescent")
                        .HasColumnType("int");

                    b.Property<int?>("Crosses")
                        .HasColumnType("int");

                    b.Property<int?>("Gold")
                        .HasColumnType("int");

                    b.Property<int?>("Green")
                        .HasColumnType("int");

                    b.Property<int?>("Icon")
                        .HasColumnType("int");

                    b.Property<string>("MainHue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Orange")
                        .HasColumnType("int");

                    b.Property<int?>("Quarters")
                        .HasColumnType("int");

                    b.Property<int?>("Red")
                        .HasColumnType("int");

                    b.Property<int?>("Saltires")
                        .HasColumnType("int");

                    b.Property<int?>("Stripes")
                        .HasColumnType("int");

                    b.Property<int?>("Sunstars")
                        .HasColumnType("int");

                    b.Property<int?>("Text")
                        .HasColumnType("int");

                    b.Property<string>("TopLeft")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Triangle")
                        .HasColumnType("int");

                    b.Property<int?>("White")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Flags");
                });
#pragma warning restore 612, 618
        }
    }
}
