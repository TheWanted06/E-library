﻿// <auto-generated />
using E_library.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace E_library.Migrations
{
    [DbContext(typeof(E_libraryContext))]
    partial class E_libraryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("E_library.Models.Book", b =>
                {
                    b.Property<int>("CallingNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CallingNo"), 1L, 1);

                    b.Property<string>("Describtion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CallingNo");

                    b.ToTable("Book");
                });
#pragma warning restore 612, 618
        }
    }
}
