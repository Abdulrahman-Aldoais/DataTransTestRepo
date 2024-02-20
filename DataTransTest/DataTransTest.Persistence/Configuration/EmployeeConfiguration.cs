using DataTransTest.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataTransTest.Persistence.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(
                new Employee
                {
                    Id = 1,
                    Email = "adffaf@gmail.com",
                    FirstName = "ahmeed",
                    LastName = "ali",
                    Phone = "454646464",
                    Address = "sanaa",
                    CreatedAt = DateTime.Now,

                },
                  new Employee
                  {
                      Id = 2,
                      Email = "ssd2af@gmail.com",
                      FirstName = "salah",
                      LastName = "ali",
                      Phone = "454646464",
                      Address = "sanaa",
                      CreatedAt = DateTime.Now,

                  },
                  new Employee
                  {
                      Id = 3,
                      Email = "example1@gmail.com",
                      FirstName = "hany",
                      LastName = "abdu",
                      Phone = "123456789",
                      Address = "sanaa",
                      CreatedAt = DateTime.Now,
                  }


                );

        }
    }
}
