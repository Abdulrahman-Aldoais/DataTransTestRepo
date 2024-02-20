using DataTransTest.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataTransTest.Persistence.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User
                {
                    Id = 1,
                    Email = "adffaf@gmail.com",
                    FirstName = "علي",
                    LastName = "الدعيس",
                    Phone = "454646464",
                    Address = "sanaa",
                    CreatedAt = DateTime.Now,

                },
                  new User
                  {
                      Id = 2,
                      Email = "ssd2af@gmail.com",
                      FirstName = "سعيد",
                      LastName = "صالح",
                      Phone = "454646464",
                      Address = "sanaa",
                      CreatedAt = DateTime.Now,

                  },
                  new User
                  {
                      Id = 3,
                      Email = "example1@gmail.com",
                      FirstName = "محمد",
                      LastName = "خالد",
                      Phone = "123456789",
                      Address = "sanaa",
                      CreatedAt = DateTime.Now,
                  },

                    new User
                    {
                        Id = 4,
                        Email = "example2@gmail.com",
                        FirstName = "فاطمة",
                        LastName = "علي",
                        Phone = "987654321",
                        Address = "sanaa",
                        CreatedAt = DateTime.Now,
                    },
                    new User
                    {
                        Id = 5,
                        Email = "example3@gmail.com",
                        FirstName = "أحمد",
                        LastName = "عبدالله",
                        Phone = "555555555",
                        Address = "sanaa",
                        CreatedAt = DateTime.Now,
                    },

                    new User
                    {
                        Id = 6,
                        Email = "example4@gmail.com",
                        FirstName = "ريم",
                        LastName = "محمد",
                        Phone = "666666666",
                        Address = "sanaa",
                        CreatedAt = DateTime.Now,
                    }


                );

        }
    }
}
