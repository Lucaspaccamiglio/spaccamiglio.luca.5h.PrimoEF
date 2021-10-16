﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using spaccamiglio.luca._5h.PrimoEF;

namespace spaccamiglio.luca._5h.PrimoEF.Migrations
{
    [DbContext(typeof(DbPersone))]
    [Migration("20211015071904_PrimaVersione")]
    partial class PrimaVersione
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("spaccamiglio.luca._5h.PrimoEF.Persona", b =>
                {
                    b.Property<int>("PersonaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cognome")
                        .HasColumnType("TEXT");

                    b.Property<string>("EMail")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("PersonaId");

                    b.ToTable("Persone");
                });
#pragma warning restore 612, 618
        }
    }
}