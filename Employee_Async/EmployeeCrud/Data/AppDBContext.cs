using EmployeeCrud.Model;
using Microsoft.EntityFrameworkCore;
namespace EmployeeCrud.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }
        public DbSet<Employee> Employees { get; set; }

    }


}
