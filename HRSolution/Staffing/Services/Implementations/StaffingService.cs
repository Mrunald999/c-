using HRLibrary.Entities;
using Staffing.Entities;
using Staffing.Repositories.Implementation;
using Staffing.Repositories.Interfaces;
using Staffing.Services.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Staffing.Services.Implementations
{
    public class StaffingService : IStaffingService
    {
        public void AddEmployee(Employee employee)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(employee);
            new StaffingRepo().AddEmployee(employee);
        }

        public void DeleteEmployee(int EmpId)
        {
            List<Employee> employees = GetAllEmployees();
            new StaffingRepo().DeleteEmployee(EmpId);
        }

        public List<Employee> GetAllEmployees()
        {
            return new StaffingRepo().GetAllEmployees();
        }

        public Employee GetEmployeeByID(int EmpId)
        {
            return new StaffingRepo().GetEmployeeById(EmpId);
        }

        public void UpdateEmployee(Employee employee)
        {
            List<Employee> employees = GetAllEmployees();
            new StaffingRepo().UpdateEmployee(employee);
        }
    }
}
