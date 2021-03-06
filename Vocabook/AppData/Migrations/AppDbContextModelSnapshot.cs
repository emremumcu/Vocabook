// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vocabook.AppData;

#nullable disable

namespace Vocabook.AppData.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.1");

            modelBuilder.Entity("Vocabook.AppData.Entities.Word", b =>
                {
                    b.Property<string>("English")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("datetime('now', 'utc')");

                    b.Property<string>("Sample")
                        .HasColumnType("TEXT");

                    b.Property<string>("Synonym")
                        .HasColumnType("TEXT");

                    b.Property<string>("Turkish")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("English");

                    b.ToTable("WordList", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
