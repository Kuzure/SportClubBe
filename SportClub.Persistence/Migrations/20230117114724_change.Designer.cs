﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SportClub.Persistance;

#nullable disable

namespace SportClub.Persistance.Migrations
{
    [DbContext(typeof(SportClubDbContext))]
    [Migration("20230117114724_change")]
    partial class change
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SportClub.Domain.Entity.Coach", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CoachClass")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreateEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("IdentityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LmDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LmEmail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdentityId")
                        .IsUnique();

                    b.ToTable("Coach", (string)null);
                });

            modelBuilder.Entity("SportClub.Domain.Entity.CoachGroup", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CoachId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreateEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("GroupId")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LmDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LmEmail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CoachId");

                    b.HasIndex("GroupId");

                    b.ToTable("CoachGroup", (string)null);
                });

            modelBuilder.Entity("SportClub.Domain.Entity.Competitor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreateEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("GroupId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdentityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPaid")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LmDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LmEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MedicalExaminationExpiryDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("IdentityId")
                        .IsUnique();

                    b.ToTable("Competitor", (string)null);
                });

            modelBuilder.Entity("SportClub.Domain.Entity.Exercise", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreateEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LmDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LmEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Repetitions")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Exercise", (string)null);
                });

            modelBuilder.Entity("SportClub.Domain.Entity.File", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreateEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("GroupId")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LmDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LmEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PathFileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UploadPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GroupId")
                        .IsUnique();

                    b.ToTable("File", (string)null);
                });

            modelBuilder.Entity("SportClub.Domain.Entity.Group", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreateEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LmDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LmEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Group", (string)null);
                });

            modelBuilder.Entity("SportClub.Domain.Entity.GroupExercise", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreateEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ExercisesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("GroupId")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LmDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LmEmail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ExercisesId");

                    b.HasIndex("GroupId");

                    b.ToTable("GroupExercise", (string)null);
                });

            modelBuilder.Entity("SportClub.Domain.Entity.Identity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreateEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Degree")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LmDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LmEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique()
                        .HasFilter("[UserId] IS NOT NULL");

                    b.ToTable("Identity", (string)null);
                });

            modelBuilder.Entity("SportClub.Domain.Entity.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreateEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LmDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LmEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Role", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("8be3d024-9f31-41c4-9768-80e2afd5cd0e"),
                            CreateDate = new DateTime(2023, 1, 17, 12, 47, 24, 215, DateTimeKind.Local).AddTicks(4199),
                            IsActive = true,
                            Name = "Competitor"
                        },
                        new
                        {
                            Id = new Guid("60359a55-3c34-4230-a5b6-6c8afa0f17e5"),
                            CreateDate = new DateTime(2023, 1, 17, 12, 47, 24, 215, DateTimeKind.Local).AddTicks(4258),
                            IsActive = true,
                            Name = "Coach"
                        },
                        new
                        {
                            Id = new Guid("c1310f5a-6187-4fc4-9de1-450eba8707bc"),
                            CreateDate = new DateTime(2023, 1, 17, 12, 47, 24, 215, DateTimeKind.Local).AddTicks(4261),
                            IsActive = true,
                            Name = "Admin"
                        });
                });

            modelBuilder.Entity("SportClub.Domain.Entity.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreateEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LmDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LmEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("SportClub.Domain.Entity.Coach", b =>
                {
                    b.HasOne("SportClub.Domain.Entity.Identity", "Identity")
                        .WithOne("Coach")
                        .HasForeignKey("SportClub.Domain.Entity.Coach", "IdentityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Identity");
                });

            modelBuilder.Entity("SportClub.Domain.Entity.CoachGroup", b =>
                {
                    b.HasOne("SportClub.Domain.Entity.Coach", "Coach")
                        .WithMany("CoachGroups")
                        .HasForeignKey("CoachId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SportClub.Domain.Entity.Group", "Group")
                        .WithMany("CoachGroups")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Coach");

                    b.Navigation("Group");
                });

            modelBuilder.Entity("SportClub.Domain.Entity.Competitor", b =>
                {
                    b.HasOne("SportClub.Domain.Entity.Group", "Group")
                        .WithMany("Competitors")
                        .HasForeignKey("GroupId");

                    b.HasOne("SportClub.Domain.Entity.Identity", "Identity")
                        .WithOne("Competitor")
                        .HasForeignKey("SportClub.Domain.Entity.Competitor", "IdentityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("Identity");
                });

            modelBuilder.Entity("SportClub.Domain.Entity.File", b =>
                {
                    b.HasOne("SportClub.Domain.Entity.Group", "Group")
                        .WithOne("File")
                        .HasForeignKey("SportClub.Domain.Entity.File", "GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");
                });

            modelBuilder.Entity("SportClub.Domain.Entity.GroupExercise", b =>
                {
                    b.HasOne("SportClub.Domain.Entity.Exercise", "Exercise")
                        .WithMany("GroupExercises")
                        .HasForeignKey("ExercisesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SportClub.Domain.Entity.Group", "Group")
                        .WithMany("GroupExercises")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exercise");

                    b.Navigation("Group");
                });

            modelBuilder.Entity("SportClub.Domain.Entity.Identity", b =>
                {
                    b.HasOne("SportClub.Domain.Entity.User", "User")
                        .WithOne("Identity")
                        .HasForeignKey("SportClub.Domain.Entity.Identity", "UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SportClub.Domain.Entity.User", b =>
                {
                    b.HasOne("SportClub.Domain.Entity.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("SportClub.Domain.Entity.Coach", b =>
                {
                    b.Navigation("CoachGroups");
                });

            modelBuilder.Entity("SportClub.Domain.Entity.Exercise", b =>
                {
                    b.Navigation("GroupExercises");
                });

            modelBuilder.Entity("SportClub.Domain.Entity.Group", b =>
                {
                    b.Navigation("CoachGroups");

                    b.Navigation("Competitors");

                    b.Navigation("File")
                        .IsRequired();

                    b.Navigation("GroupExercises");
                });

            modelBuilder.Entity("SportClub.Domain.Entity.Identity", b =>
                {
                    b.Navigation("Coach")
                        .IsRequired();

                    b.Navigation("Competitor")
                        .IsRequired();
                });

            modelBuilder.Entity("SportClub.Domain.Entity.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("SportClub.Domain.Entity.User", b =>
                {
                    b.Navigation("Identity")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
