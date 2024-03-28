using Microsoft.EntityFrameworkCore;
using wba.Assignments.core.entities;

namespace wba.Assignments.web.Data
{
    public class AssignmentDBContext : DbContext
    {

        //DBsets
        //primary tables
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }

        public AssignmentDBContext(DbContextOptions<AssignmentDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Add seeding method here
            DataSeeder.Seed(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }
    }
}
