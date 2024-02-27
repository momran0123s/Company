using Company.Models;

namespace Company.Repositories
{
    public interface IEmployeeRepo
    {
        int AddEmployee(Employee emp);
        int DeleteEmployee(int id);
        List<Employee> GetAllEmployees();
        Employee GetEmployeeById(int id);
        int UpdateEmployee(Employee emp);
    }
}