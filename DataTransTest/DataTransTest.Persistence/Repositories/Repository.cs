using Dapper;
using DataTransTest.Domain.Entity;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DataTransTest.Persistence.Repositories
{
    public class Repository
    {
        public SqlConnection con;
        //To Handle connection related activities
        private void connection()
        {
            //string constr = ConfigurationManager.ConnectionStrings["SqlConn"].ToString();
            //con = new SqlConnection(constr);
        }
        //To Add Employee details
        public void AddEmployee(Employee objEmp)
        {
            //Additing the employess
            try
            {
                connection();
                con.Open();
                con.Execute("AddNewEmpDetails", objEmp, commandType: CommandType.StoredProcedure);
                con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //To view employee details with generic list 
        public List<Employee> GetAllEmployees()
        {
            try
            {
                connection();
                con.Open();
                IList<Employee> EmpList = con.Query<Employee>(
"GetEmployees").ToList();
                con.Close();
                return EmpList.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
        //To Update Employee details
        public void UpdateEmployee(Employee objUpdate)
        {
            try
            {
                connection();
                con.Open();
                con.Execute("UpdateEmpDetails", objUpdate, commandType: CommandType.StoredProcedure);
                con.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
        //To delete Employee details
        public bool DeleteEmployee(int Id)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@EmpId", Id);
                connection();
                con.Open();
                con.Execute("DeleteEmpById", param, commandType: CommandType.StoredProcedure);
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                //Log error as per your need 
                throw ex;
            }
        }
    }
}
