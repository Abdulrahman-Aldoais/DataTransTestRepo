using Core.Persistence.Repositories.Abstracts;
using DataTransTest.Application.Repositories.EmployeeRepositoty;
using DataTransTest.Domain.Entity;
using DataTransTest.Persistence.DataBase;

namespace DataTransTest.Persistence.Repositories.EmployeeRepository
{
    public class EmployeeWriteRepository : WriteRepository<Employee, ApplicationDbContext>, IEmployeeWriteRepositoty
    {
        public EmployeeWriteRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
