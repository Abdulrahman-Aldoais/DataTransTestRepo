using DataTransTest.Application.Serveses.EmployeeServices;
using DataTransTest.Domain.Entity;
using Microsoft.AspNetCore.Mvc;

namespace DataTransTest.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee/GetAllEmpDetails
        private readonly IEmployeeService _employeeService;


        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        public async Task<IActionResult> GetAllEmpDetails()
        {
            var allEmployees = await _employeeService.GetAll();
            return View(allEmployees);
        }
        // GET: Employee/AddEmployee
        public async Task<IActionResult> AddEmployee()
        {
            return View();
        }
        // POST: Employee/AddEmployee
        [HttpPost]
        public async Task<IActionResult> AddEmployee(Employee Emp)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    await _employeeService.Add(Emp);
                    ViewBag.Message = "Records added successfully.";
                    return RedirectToAction(nameof(GetAllEmpDetails));
                }
                return View();
            }
            catch
            {
                return View();
            }
        }
        // GET: Bind controls to Update details
        public async Task<IActionResult> EditEmpDetails(int id)
        {
            var getEmp = await _employeeService.GetById(id);
            return View(getEmp);
        }
        // POST:Update the details into database
        [HttpPost]
        public async Task<IActionResult> EditEmpDetails(int id, Employee obj)
        {
            try
            {

                await _employeeService.Update(id, obj);
                return RedirectToAction("GetAllEmpDetails");
            }
            catch
            {
                return View();
            }
        }
        // GET: Delete  Employee details by id
        //public ActionResult DeleteEmp(int id)
        //{
        //    try
        //    {
        //        Repository EmpRepo = new Repository();
        //        if (EmpRepo.DeleteEmployee(id))
        //        {
        //            ViewBag.AlertMsg = "Employee details deleted successfully";
        //        }
        //        return RedirectToAction("GetAllEmpDetails");
        //    }
        //    catch
        //    {
        //        return RedirectToAction("GetAllEmpDetails");
        //    }
        //}
    }
}
