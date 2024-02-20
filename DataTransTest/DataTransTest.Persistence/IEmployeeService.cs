using DataTransTest.Domain.Entity;

namespace DataTransTest.Application.Serveses.EmployeeServices
{
    public interface IEmployeeService
    {
        public Task<IEnumerable<Employee>> GetAll();
        public Task<Employee> GetById(int? id);
        public Task<Employee> Add(Employee employee);
        public Task Update(int id, Employee employee);
        public Task Remove(int id);
    }
}
