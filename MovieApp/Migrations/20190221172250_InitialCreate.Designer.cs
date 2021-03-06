﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieApp.NewDb;

namespace MovieApp.Migrations
{
    [DbContext(typeof(MovieContext))]
    [Migration("20190221172250_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MovieApp.NewDb.Movietbl", b =>
                {
                    b.Property<string>("year")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("category_name");

                    b.HasKey("year");

                    b.ToTable("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
