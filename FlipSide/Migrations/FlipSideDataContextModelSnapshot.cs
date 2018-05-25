﻿// <auto-generated />
using FlipSide.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace FlipSide.Migrations
{
    [DbContext(typeof(FlipSideDataContext))]
    partial class FlipSideDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MvcMovie.Models.Story", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("byline");

                    b.Property<DateTime>("dateRan");

                    b.Property<decimal>("lean");

                    b.Property<DateTime>("slug");

                    b.Property<string>("summary");

                    b.HasKey("ID");

                    b.ToTable("Story");
                });
#pragma warning restore 612, 618
        }
    }
}
