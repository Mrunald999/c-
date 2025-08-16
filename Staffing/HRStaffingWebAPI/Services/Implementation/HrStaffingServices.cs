using HRStaffingWebAPI.Entities;
using HRStaffingWebAPI.Repositories.Implementation;
using HRStaffingWebAPI.Repositories.Interfaces;
using HRStaffingWebAPI.Services.Intefaces;

namespace HRStaffingWebAPI.Services.Implementation
{
    public class HrStaffingServices : IHrStaffingServices
    {
        public IHRStaffingRepo repo;
        public HrStaffingServices(IHRStaffingRepo _repo) 
        {
            repo = _repo;
        }
        public void AddEmployee(Employee employee)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(employee);
            new HRStaffingRepo().AddEmployee(employee);
        }

        public void DeleteEmployee(int EmpId)
        {
            List<Employee> employees = GetAllEmployees();
            new HRStaffingRepo().DeleteEmployee(EmpId);
        }

        public List<Employee> GetAllEmployees()
        {
            return new HRStaffingRepo().GetAllEmployees();
        }

        public Employee GetEmployeeByID(int EmpId)
        {
            return new HRStaffingRepo().GetEmployeeById(EmpId);
        }

        public void UpdateEmployee(Employee employee)
        {
            List<Employee> employees = GetAllEmployees();
            new HRStaffingRepo().UpdateEmployee(employee);
        }
    }
}
