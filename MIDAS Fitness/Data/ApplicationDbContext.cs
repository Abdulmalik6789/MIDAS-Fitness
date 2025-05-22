using Microsoft.EntityFrameworkCore;
using MIDAS_Fitness.Models;

namespace MIDAS_Fitness.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<PersonalDetails> PersonalDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure PersonalDetails entity
            modelBuilder.Entity<PersonalDetails>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<PersonalDetails>()
                .Property(p => p.FirstName)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<PersonalDetails>()
                .Property(p => p.LastName)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<PersonalDetails>()
                .Property(p => p.Email)
                .IsRequired()
                .HasMaxLength(255);

            modelBuilder.Entity<PersonalDetails>()
                .Property(p => p.PasswordHash)
                .IsRequired();

            modelBuilder.Entity<PersonalDetails>()
                .Property(p => p.CellPhone)
                .IsRequired()
                .HasMaxLength(20);

            modelBuilder.Entity<PersonalDetails>()
                .Property(p => p.Street)
                .IsRequired()
                .HasMaxLength(255);

            modelBuilder.Entity<PersonalDetails>()
                .Property(p => p.City)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<PersonalDetails>()
                .Property(p => p.PostalCode)
                .IsRequired()
                .HasMaxLength(20);

         
        }
    }
}
