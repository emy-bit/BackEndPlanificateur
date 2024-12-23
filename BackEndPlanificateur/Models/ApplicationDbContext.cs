using Microsoft.EntityFrameworkCore;

namespace BackEndPlanificateur.Models
{
    public class ApplicationDbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<voyage> voyages { get; set; }
        public DbSet<Membre> Memembres { get; set; }
        public DbSet<Destination> Destination { get; set; }
        public DbSet<Activites> Activites { get; set; }
        public DbSet<Depenses> Depenses { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

    }
}
