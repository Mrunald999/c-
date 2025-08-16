

using Staffing.Entities;
using Staffing.Services.Implementations;
using Staffing.Services.Intefaces;
using System;


IStaffingService staffingService = new StaffingService();
List<Employee> employeeList = new List<Employee>();
employeeList = staffingService.GetAllEmployees();

foreach (Employee emp in employeeList)
{
    Console.WriteLine(emp.EmpId + " " + emp.Name + " " + emp.Salary);
}

