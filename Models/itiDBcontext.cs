using Microsoft.EntityFrameworkCore;

namespace MvCITI.Models
{
    public class itiDBcontext:DbContext
    {
        public itiDBcontext():base()
        {
            
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<dept> Depts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectModels;Initial Catalog=itimvc;Integrated Security=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
