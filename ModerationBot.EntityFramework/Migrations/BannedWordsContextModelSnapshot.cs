﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TheFirmGG.EntityFramework;

namespace TheFirmGG.EntityFramework.Migrations
{
    [DbContext(typeof(BannedWordsContext))]
    partial class BannedWordsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("TheFirmGG.EntityFramework.Models.BannedWord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("BannedWordRegex")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("BannedWords");
                });
#pragma warning restore 612, 618
        }
    }
}