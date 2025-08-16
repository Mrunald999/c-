using HRStaffingWebAPI.Entities;

namespace HRStaffingWebAPI.Services.Intefaces
{
    public interface IHrStaffingServices
    {
        List<Employee> GetAllEmployees();
        Employee GetEmployeeByID(int EmpId);
        public void AddEmployee(Employee employee);
        public void DeleteEmployee(int EmpId);
        public void UpdateEmployee(Employee employee);
    }
}
