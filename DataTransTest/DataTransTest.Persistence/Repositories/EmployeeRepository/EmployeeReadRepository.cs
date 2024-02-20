using Core.Persistence.Repositories.Abstracts;
using DataTransTest.Application.Repositories.EmployeeRepositoty;
using DataTransTest.Domain.Entity;
using DataTransTest.Persistence.DataBase;

namespace DataTransTest.Persistence.Repositories.EmployeeRepository
{
    public class EmployeeReadRepository : ReadRepository<Employee, ApplicationDbContext>, IEmployeeReadRepositoty
    {
        public EmployeeReadRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
