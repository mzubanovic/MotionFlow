﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MotionFlow.Data;

#nullable disable

namespace MotionFlow.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MotionFlow.Models.BodyPart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BodyParts");
                });

            modelBuilder.Entity("MotionFlow.Models.Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VideoUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Exercises");
                });

            modelBuilder.Entity("MotionFlow.Models.ExerciseVsBodyPart", b =>
                {
                    b.Property<int>("ExerciseId")
                        .HasColumnType("int");

                    b.Property<int>("BodyPartId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("ExerciseId", "BodyPartId");

                    b.HasIndex("BodyPartId");

                    b.ToTable("ExerciseVsBodyParts");
                });

            modelBuilder.Entity("MotionFlow.Models.ExerciseVsPhysio", b =>
                {
                    b.Property<int>("ExerciseId")
                        .HasColumnType("int");

                    b.Property<int>("PhysioId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("ExerciseId", "PhysioId");

                    b.HasIndex("PhysioId");

                    b.ToTable("ExerciseVsPhysios");
                });

            modelBuilder.Entity("MotionFlow.Models.Physio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsSuperAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Physios");
                });

            modelBuilder.Entity("MotionFlow.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MotionFlow.Models.UserVsPhysio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("PhysioId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PhysioId");

                    b.HasIndex("UserId");

                    b.ToTable("UserVsPhysios");
                });

            modelBuilder.Entity("MotionFlow.Models.ExerciseVsBodyPart", b =>
                {
                    b.HasOne("MotionFlow.Models.BodyPart", "BodyPart")
                        .WithMany("ExerciseVsBodyParts")
                        .HasForeignKey("BodyPartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MotionFlow.Models.Exercise", "Exercise")
                        .WithMany("ExerciseVsBodyParts")
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BodyPart");

                    b.Navigation("Exercise");
                });

            modelBuilder.Entity("MotionFlow.Models.ExerciseVsPhysio", b =>
                {
                    b.HasOne("MotionFlow.Models.Exercise", "Exercise")
                        .WithMany("ExercisesVsPhysio")
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MotionFlow.Models.Physio", "Physio")
                        .WithMany("ExerciseVsPhysios")
                        .HasForeignKey("PhysioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exercise");

                    b.Navigation("Physio");
                });

            modelBuilder.Entity("MotionFlow.Models.UserVsPhysio", b =>
                {
                    b.HasOne("MotionFlow.Models.Physio", "Physio")
                        .WithMany()
                        .HasForeignKey("PhysioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MotionFlow.Models.User", "User")
                        .WithMany("UsersVsPhysio")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Physio");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MotionFlow.Models.BodyPart", b =>
                {
                    b.Navigation("ExerciseVsBodyParts");
                });

            modelBuilder.Entity("MotionFlow.Models.Exercise", b =>
                {
                    b.Navigation("ExerciseVsBodyParts");

                    b.Navigation("ExercisesVsPhysio");
                });

            modelBuilder.Entity("MotionFlow.Models.Physio", b =>
                {
                    b.Navigation("ExerciseVsPhysios");
                });

            modelBuilder.Entity("MotionFlow.Models.User", b =>
                {
                    b.Navigation("UsersVsPhysio");
                });
#pragma warning restore 612, 618
        }
    }
}
