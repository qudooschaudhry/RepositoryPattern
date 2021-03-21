﻿// <auto-generated />
using System;
using LMS.Infrastructure.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LMS.Infrastructure.Migrations
{
    [DbContext(typeof(LMSContext))]
    partial class LMSContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LMS.Domain.Chapter", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Chapter");
                });

            modelBuilder.Entity("LMS.Domain.Content", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ContentType")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contents");
                });

            modelBuilder.Entity("LMS.Domain.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EndDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StartDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("LMS.Domain.Page", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ChapterId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ChapterId");

                    b.ToTable("Pages");
                });

            modelBuilder.Entity("LMS.Domain.Section", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ContentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Heading")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<Guid?>("PageId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ContentId");

                    b.HasIndex("PageId");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("LMS.Domain.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("LMS.Domain.Chapter", b =>
                {
                    b.HasOne("LMS.Domain.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId");

                    b.Navigation("Course");
                });

            modelBuilder.Entity("LMS.Domain.Course", b =>
                {
                    b.HasOne("LMS.Domain.Student", null)
                        .WithMany("Courses")
                        .HasForeignKey("StudentId");
                });

            modelBuilder.Entity("LMS.Domain.Page", b =>
                {
                    b.HasOne("LMS.Domain.Chapter", "Chapter")
                        .WithMany()
                        .HasForeignKey("ChapterId");

                    b.Navigation("Chapter");
                });

            modelBuilder.Entity("LMS.Domain.Section", b =>
                {
                    b.HasOne("LMS.Domain.Content", "Content")
                        .WithMany()
                        .HasForeignKey("ContentId");

                    b.HasOne("LMS.Domain.Page", "Page")
                        .WithMany("Sections")
                        .HasForeignKey("PageId");

                    b.Navigation("Content");

                    b.Navigation("Page");
                });

            modelBuilder.Entity("LMS.Domain.Page", b =>
                {
                    b.Navigation("Sections");
                });

            modelBuilder.Entity("LMS.Domain.Student", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
