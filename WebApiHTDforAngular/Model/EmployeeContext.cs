using Microsoft.EntityFrameworkCore;

namespace WebApiHTDforAngular.Model
{
    public class EmployeeContext :DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {
        }
        public DbSet<TblEmployees> TblEmployee { get; set; }
        public DbSet<TblDesignation> TblDesignation { get; set; }
        public virtual DbSet<Register> Register { get; set; }
    }
}