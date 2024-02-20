using Core.Persistence.Repositories.Interface;
using DataTransTest.Domain.Entity;

namespace DataTransTest.Application.Repositories.EmployeeRepositoty
{
    public interface IEmployeeWriteRepositoty : IWriteRepository<Employee>
    {
    }
}
