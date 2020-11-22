using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Models

// Installing EF-Core:
// dotnet add package Microsoft.EntityFrameworkCore.SqlServer   -- EF-Core DB provider
// dotnet add package Microsoft.EntityFrameworkCore.Tools       -- EF-Core Tools

{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
    }
}