using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EmployeePayrollSystem
{
    class EmpDbContext: DbContext
    {
        public EmpDbContext():base("EmployeeDatabase")
        {
                    
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Employee> Employee { get; set; }

        public DbSet<EmployeeDetails> EmployeeDetails { get; set; }

    }
}