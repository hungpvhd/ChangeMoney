﻿// <auto-generated />
using ChangeMoney.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ChangeMoney.Migrations
{
    [DbContext(typeof(ChangeMoneyContext))]
    [Migration("20190108150537_ChangeMoney")]
    partial class ChangeMoney
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ChangeMoney.Data.ChangeCurrencycs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Currrency");

                    b.Property<long>("ratio");

                    b.HasKey("Id");

                    b.ToTable("ChangeCurrencycs");
                });
#pragma warning restore 612, 618
        }
    }
}