using Microsoft.EntityFrameworkCore;
using MotionFlow.Models;

namespace MotionFlow.Data
{
    // naša klasa inherita od DbContext od Entity-a
    public class AppDbContext : DbContext
    {
        public DbSet<BodyPart> BodyParts { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Physio> Physios { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ExerciseVsBodyPart> ExerciseVsBodyParts { get; set; }
        public DbSet<ExerciseVsPhysio> ExerciseVsPhysios { get; set; }
        public DbSet<UserVsPhysio> UserVsPhysios { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExerciseVsBodyPart>()
                .HasKey(ebp => new { ebp.ExerciseId, ebp.BodyPartId });

            modelBuilder.Entity<ExerciseVsBodyPart>()
                .HasOne(ebp => ebp.Exercise)
                .WithMany(e => e.ExerciseVsBodyParts)
                .HasForeignKey(ebp => ebp.ExerciseId);

            modelBuilder.Entity<ExerciseVsBodyPart>()
                .HasOne(ebp => ebp.BodyPart)
                .WithMany(bp => bp.ExerciseVsBodyParts)
                .HasForeignKey(ebp => ebp.BodyPartId);

            modelBuilder.Entity<ExerciseVsPhysio>()
                .HasKey(ep => new { ep.ExerciseId, ep.PhysioId });

            modelBuilder.Entity<ExerciseVsPhysio>()
                .HasOne(ep => ep.Exercise)
                .WithMany(e => e.ExercisesVsPhysio)
                .HasForeignKey(ep => ep.ExerciseId);

            modelBuilder.Entity<ExerciseVsPhysio>()
                .HasOne(ep => ep.Physio)
                .WithMany(p => p.ExerciseVsPhysios)
                .HasForeignKey(ep => ep.PhysioId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
