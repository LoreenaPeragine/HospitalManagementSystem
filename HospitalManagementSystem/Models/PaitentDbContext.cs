using Microsoft.EntityFrameworkCore;

namespace HospitalManagementSystem.Models
{
    public class PaitentDbContext : DbContext
    {
        public PaitentDbContext(DbContextOptions<PaitentDbContext> options) : base(options)
        { }

        public DbSet<Patient> Patients { get; set; }
    }
}
