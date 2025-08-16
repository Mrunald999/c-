using Staffing.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Staffing.Repositories.Implementation;

namespace Staffing.Services.Intefaces
{
    public interface IStaffingService

    {
        List<Employee> GetAllEmployees();
        Employee GetEmployeeByID(int EmpId);
        public void AddEmployee(Employee employee);
        public void DeleteEmployee(int EmpId);
        public void UpdateEmployee(Employee employee);
        
    }
}
