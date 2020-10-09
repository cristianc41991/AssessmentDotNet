﻿// <auto-generated />
using AssessmentDotNet2020.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AssessmentDotNet2020.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AssessmentDotNet2020.Shared.Entities.Cola", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("cola")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("time")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Colas");
                });

            modelBuilder.Entity("AssessmentDotNet2020.Shared.Entities.ColaPeople", b =>
                {
                    b.Property<int>("ColaId")
                        .HasColumnType("int");

                    b.Property<int>("PeopleId")
                        .HasColumnType("int");

                    b.Property<int>("position")
                        .HasColumnType("int");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("ColaId", "PeopleId");

                    b.HasIndex("PeopleId");

                    b.ToTable("ColaPeoples");
                });

            modelBuilder.Entity("AssessmentDotNet2020.Shared.Entities.People", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Peoples");
                });

            modelBuilder.Entity("AssessmentDotNet2020.Shared.Entities.ColaPeople", b =>
                {
                    b.HasOne("AssessmentDotNet2020.Shared.Entities.Cola", "Cola")
                        .WithMany()
                        .HasForeignKey("ColaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AssessmentDotNet2020.Shared.Entities.People", "People")
                        .WithMany()
                        .HasForeignKey("PeopleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}