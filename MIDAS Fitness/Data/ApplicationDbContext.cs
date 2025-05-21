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
        }
    }
}