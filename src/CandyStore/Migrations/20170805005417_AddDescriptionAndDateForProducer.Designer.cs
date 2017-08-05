using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using CandyStore.Models;

namespace CandyStore.Migrations
{
    [DbContext(typeof(CandyStoreContext))]
    [Migration("20170805005417_AddDescriptionAndDateForProducer")]
    partial class AddDescriptionAndDateForProducer
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CandyStore.Models.Producer", b =>
                {
                    b.Property<int>("ProducerId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Country");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("PartnerSince");

                    b.HasKey("ProducerId");

                    b.ToTable("Producers");
                });

            modelBuilder.Entity("CandyStore.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Cost");

                    b.Property<string>("Description");

                    b.Property<string>("Image");

                    b.Property<int>("ProducerId");

                    b.Property<string>("Size");

                    b.Property<string>("Title");

                    b.HasKey("ProductId");

                    b.HasIndex("ProducerId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("CandyStore.Models.Product", b =>
                {
                    b.HasOne("CandyStore.Models.Producer")
                        .WithMany("Products")
                        .HasForeignKey("ProducerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
