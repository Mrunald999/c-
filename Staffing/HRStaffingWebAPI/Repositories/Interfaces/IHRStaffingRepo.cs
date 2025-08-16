using HRStaffingWebAPI.Entities;

namespace HRStaffingWebAPI.Repositories.Interfaces
{
    public interface IHRStaffingRepo
    {
        List<Employee> GetAllEmployees();
        Employee GetEmployeeById(int empId);
        bool AddEmployee(Employee employee);
        bool UpdateEmployee(Employee employee);
        bool DeleteEmployee(int empId);
    }
}
