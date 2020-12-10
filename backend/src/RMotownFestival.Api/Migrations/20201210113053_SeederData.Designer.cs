﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RMotownFestival.Api.DAL;

namespace RMotownFestival.Api.Migrations
{
    [DbContext(typeof(MotownDbContext))]
    [Migration("20201210113053_SeederData")]
    partial class SeederData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("RMotownFestival.Api.Domain.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImagePath = "dianaross.jpg",
                            Name = "Diana Ross",
                            Website = "http://www.dianaross.co.uk/indexb.html"
                        },
                        new
                        {
                            Id = 2,
                            ImagePath = "thecommodores.jpg",
                            Name = "The Commodores",
                            Website = "http://en.wikipedia.org/wiki/Commodores"
                        },
                        new
                        {
                            Id = 3,
                            ImagePath = "steviewonder.jpg",
                            Name = "Stevie Wonder",
                            Website = "http://www.steviewonder.net/"
                        },
                        new
                        {
                            Id = 4,
                            ImagePath = "lionelrichie.jpg",
                            Name = "Lionel Richie",
                            Website = "http://lionelrichie.com/"
                        },
                        new
                        {
                            Id = 5,
                            ImagePath = "marvingaye.jpg",
                            Name = "Marvin Gaye",
                            Website = "http://www.marvingayepage.net/"
                        });
                });

            modelBuilder.Entity("RMotownFestival.Api.Domain.Stage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Stages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A music festival is a festival oriented towards music that is sometimes presented with a theme such as musical genre, nationality or locality of musicians, or holiday. They are commonly held outdoors, and are often inclusive of other attractions such as food and merchandise vending machines, performance art, and social activities. Large music festivals such as Lollapalooza are constructed around well known main stage acts and lesser known musicians and bands on side stages. Many festivals are annual, or repeat at some other interval, and have modular staging of many types. Each year Lollapalooza often features multiple acts on its main and side stages.",
                            Name = "Main Stage"
                        },
                        new
                        {
                            Id = 2,
                            Description = "A music festival is a festival oriented towards music that is sometimes presented with a theme such as musical genre, nationality or locality of musicians, or holiday. They are commonly held outdoors, and are often inclusive of other attractions such as food and merchandise vending machines, performance art, and social activities. Large music festivals such as Lollapalooza are constructed around well known main stage acts and lesser known musicians and bands on side stages. Many festivals are annual, or repeat at some other interval, and have modular staging of many types. Each year Lollapalooza often features multiple acts on its main and side stages.",
                            Name = "Orange Room"
                        },
                        new
                        {
                            Id = 3,
                            Description = "A music festival is a festival oriented towards music that is sometimes presented with a theme such as musical genre, nationality or locality of musicians, or holiday. They are commonly held outdoors, and are often inclusive of other attractions such as food and merchandise vending machines, performance art, and social activities. Large music festivals such as Lollapalooza are constructed around well known main stage acts and lesser known musicians and bands on side stages. Many festivals are annual, or repeat at some other interval, and have modular staging of many types. Each year Lollapalooza often features multiple acts on its main and side stages.",
                            Name = "StarDust"
                        },
                        new
                        {
                            Id = 4,
                            Description = "A music festival is a festival oriented towards music that is sometimes presented with a theme such as musical genre, nationality or locality of musicians, or holiday. They are commonly held outdoors, and are often inclusive of other attractions such as food and merchandise vending machines, performance art, and social activities. Large music festivals such as Lollapalooza are constructed around well known main stage acts and lesser known musicians and bands on side stages. Many festivals are annual, or repeat at some other interval, and have modular staging of many types. Each year Lollapalooza often features multiple acts on its main and side stages.",
                            Name = "Pink Room"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
