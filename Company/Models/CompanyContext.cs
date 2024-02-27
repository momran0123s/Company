using Microsoft.EntityFrameworkCore;

namespace Company.Models
{
    public class CompanyContext : DbContext
    {
        public CompanyContext()
        {
            
        }
        public CompanyContext(DbContextOptions<CompanyContext> options): base(options)
        {
            
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Dependant> Dependants { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<WorksFor> worksFor { get; set; }
    }
}
