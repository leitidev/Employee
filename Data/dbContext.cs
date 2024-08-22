using Employee.Models;
using Microsoft.EntityFrameworkCore;

namespace Employee.Data
{
    public class dbContext : DbContext
    {
        public dbContext(DbContextOptions<dbContext> options) : base(options) { }

        public DbSet<Empregado> Empregado { get; set; }
        public DbSet<Departamento> Departamento { get; set; }
    }
}
