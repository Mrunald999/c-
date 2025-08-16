using HRLibrary.Entities;
using Staffing.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Staffing.Repositories.Interfaces
{
    public interface IStaffingRepo
    {
        List<Employee> GetAllEmployees();
        Employee GetEmployeeById(int EmpId);
        bool AddEmployee(Employee employee);
        bool UpdateEmployee(Employee employee);
        bool DeleteEmployee(int employee);

    }
}
