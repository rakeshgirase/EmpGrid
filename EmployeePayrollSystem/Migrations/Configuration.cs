namespace EmployeePayrollSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<EmployeePayrollSystem.EmpDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EmployeePayrollSystem.EmpDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Employee.AddOrUpdate(emp => emp.EmpId,
            new Employee() { EmpId = 1, FirstName = "Avatar", LastName = "Girase", HireDate = new DateTime(2017, 10, 15) },
            new Employee() { EmpId = 2, FirstName = "Avatar", LastName = "Girase", HireDate = new DateTime(2017, 10, 16) },
            new Employee() { EmpId = 3, FirstName = "Avatar", LastName = "Girase", HireDate = new DateTime(2017, 10, 17) },
            new Employee() { EmpId = 4, FirstName = "Avatar", LastName = "Girase", HireDate = new DateTime(2017, 10, 18) });
        }
    }
}
