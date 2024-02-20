//using DataTransTest.Reposito;
//using Microsoft.AspNetCore.Mvc;

//namespace DataTransTest.Controllers
//{
//    public class EmployeeController : Controller
//    {
//        // GET: Employee/GetAllEmpDetails
//        public ActionResult GetAllEmpDetails()
//        {
//            Repository EmpRepo = new Repository();
//            return View(EmpRepo.GetAllEmployees());
//        }
//        // GET: Employee/AddEmployee
//        public ActionResult AddEmployee()
//        {
//            return View();
//        }
//        // POST: Employee/AddEmployee
//        [HttpPost]
//        public ActionResult AddEmployee(EmpModel Emp)
//        {
//            try
//            {
//                if (ModelState.IsValid)
//                {
//                    Repository EmpRepo = new Repository();
//                    EmpRepo.AddEmployee(Emp);
//                    ViewBag.Message = "Records added successfully.";
//                }
//                return View();
//            }
//            catch
//            {
//                return View();
//            }
//        }
//        // GET: Bind controls to Update details
//        public ActionResult EditEmpDetails(int id)
//        {
//            Repository EmpRepo = new Repository();
//            return View(EmpRepo.GetAllEmployees().Find(Emp => Emp.Empid == id));
//        }
//        // POST:Update the details into database
//        [HttpPost]
//        public ActionResult EditEmpDetails(int id, EmpModel obj)
//        {
//            try
//            {
//                Repository EmpRepo = new Repository();
//                EmpRepo.UpdateEmployee(obj);
//                return RedirectToAction("GetAllEmpDetails");
//            }
//            catch
//            {
//                return View();
//            }
//        }
//        // GET: Delete  Employee details by id
//        public ActionResult DeleteEmp(int id)
//        {
//            try
//            {
//                Repository EmpRepo = new Repository();
//                if (EmpRepo.DeleteEmployee(id))
//                {
//                    ViewBag.AlertMsg = "Employee details deleted successfully";
//                }
//                return RedirectToAction("GetAllEmpDetails");
//            }
//            catch
//            {
//                return RedirectToAction("GetAllEmpDetails");
//            }
//        }
//    }
//}
