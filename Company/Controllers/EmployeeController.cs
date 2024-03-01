using Company.Models;
using Company.Repositories;
using Microsoft.AspNetCore.Mvc;
namespace Company.Controllers
{
    public class EmployeeController : Controller
    {
        public IEmployeeRepo employeeRepo;
        public EmployeeController(IEmployeeRepo _employeeRepo)
        {
            employeeRepo = _employeeRepo;
        }
        public IActionResult Index()
        {
            List<Employee> employees = employeeRepo.GetAllEmployees();

            return View(employees);
        }
        [HttpGet]
        public IActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddEmployee(Employee emp)
        {
            employeeRepo.AddEmployee(emp);
            return RedirectToAction("Index");
        }


    }
}
