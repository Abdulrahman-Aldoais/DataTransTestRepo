

using Core.Persistence.Repositories.Interface;
using DataTransTest.Domain.Entity;

namespace DataTransTest.Application.Repositories.EmployeeRepositoty
{
    public interface IEmployeeReadRepositoty : IReadRepository<Employee>
    {
    }
}
