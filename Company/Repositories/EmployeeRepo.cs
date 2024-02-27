using Company.Models;

namespace Company.Repositories
{
    public class EmployeeRepo : IEmployeeRepo
    {
        CompanyContext context;
        public EmployeeRepo(CompanyContext _context)
        {
            context = _context;
        }
        public List<Employee> GetAllEmployees()
        {
            return context.Employees.ToList();
        }

        public Employee GetEmployeeById(int id)
        {
            return context.Employees.SingleOrDefault(e => e.SSN == id);
        }
        public int AddEmployee(Employee emp)
        {
            context.Employees.Add(emp);
            return context.SaveChanges();
        }
        public int UpdateEmployee(Employee emp)
        {
            context.Employees.Update(emp);
            return context.SaveChanges();
        }
        public int DeleteEmployee(int id)
        {
            context.Employees.Remove(GetEmployeeById(id));
            return context.SaveChanges();
        }
    }
}
