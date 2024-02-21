

using Dapper;
using DataTransTest.Application.Serveses.EmployeeServices;
using DataTransTest.Domain.Entity;
using DataTransTest.Persistence.DataBase;
using System.Data;

namespace DataTransTest.Persistence
{
    public class EmployeeService : IEmployeeService
    {
        private readonly DapperContext _context;
        public EmployeeService(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Employee>> GetAll()
        {
            var query = "SELECT * FROM Employees";
            using var connection = _context.CreateConnection();
            var categories = await connection.QueryAsync<Employee>(query);
            return categories.ToList();
        }

        public async Task<Employee?> GetById(int? id)
        {
            var query = "SELECT * FROM Employees WHERE Id = @Id";
            using var connection = _context.CreateConnection();
            var category = await connection.QuerySingleOrDefaultAsync<Employee>(query, new { id });
            return category;
        }





        public async Task<Employee> Add(Employee category)
        {
            try
            {
                var insertQuery = "INSERT INTO Employees (FirstName, LastName, Phone, Address, Email, CreatedAt) " +
                   "VALUES (@FirstName, @LastName, @Phone, @Address, @Email, GETDATE());";



                using var connection = _context.CreateConnection();

                // Execute the query for the INSERT operation
                await connection.ExecuteAsync(insertQuery, category);

                // Retrieve the last inserted identity
                var id = await connection.ExecuteScalarAsync<int>("SELECT CAST(SCOPE_IDENTITY() as int)");

                var createdEmployee = new Employee
                {
                    Id = id,
                    FirstName = category.FirstName,
                    LastName = category.LastName,
                    Address = category.Address,
                    CreatedAt = DateTime.Now,
                    Email = category.Email,
                    Phone = category.Phone
                };

                return createdEmployee;
            }
            catch (Exception ex)
            {
                // Log or print exception details
                Console.WriteLine("Error in Add method:");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                throw; // Re-throw the exception to propagate it further
            }
        }



        public async Task Update(int id, Employee category)
        {
            var query = "UPDATE Employees SET FirstName = @FirstName, LastName = @LastName,UpdateAt, " +
                        "Phone = @Phone, Address = @Address, Email = @Email,GETDATE(), WHERE Id = @Id";

            var parameters = new DynamicParameters();
            parameters.Add("@Id", id, DbType.Int32);
            parameters.Add("@FirstName", category.FirstName, DbType.String);
            parameters.Add("@LastName", category.LastName, DbType.String);
            parameters.Add("@Phone", category.Phone, DbType.String);
            parameters.Add("@Address", category.Address, DbType.String);
            parameters.Add("@Email", category.Email, DbType.String);

            using var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, parameters);
        }


        public async Task Remove(int id)
        {
            var query = "DELETE FROM Employees WHERE Id = @Id";
            using var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, new { id });
        }

    }
}
