namespace HR.Repository;

using HR.Utility;
using HR.Entities;

public class EmployeeRepository : IEmployeeRepository
{
    List<Product> allProducts = null;
    string filepath = @"C:\Users\MrunalNandkumarDeshp\Desktop\Mrunal\Code\Employee.json";

    public EmployeeRepository()
    {
        allEmployees = new List<Employee>();
    }

    public Employee GetByID(int id)
    {
        List<Employee> allEmployees = GetAll() as List<Employee>;
        Employee theEmployee = allEmployees.Find(x => x.Id == id);
        return theEmployee;
    }

    public List<Employee> GetAll()
    {
        List<Employee> allEmployees = JsonFileManager.Load(filePath);
        return allEmployees;
    }
    public bool Add(Employee employee)
    {
        List<Employee> allEmployees = GetAll() as List<Employee>;
        allEmployee.Add(employee);
        bool status = JsonFileManager.Save(filePath, allEmployees);
        return status;
    }
    public bool Update(Employee employeew)
    {
        Employee FoundEmployee = GetByID(employeew.Id);
        if (foundEmployee != null)
        {
            foundEmployee.EmpId = employee.EmpId;
            foundEmployee.EmpName = employee.EmpName;
            foundEmployee.EmpName = employee.EmpName;
        }
        bool status = JsonFileManager.Save(filePath, allEmployees);
        return status;
    }

    public void Remove(int id)
    {
        List<Employee> allEmployees = GetAll() as List<Employee>;
        Employee foundEmployee = GetById(id);
        if (foundEmployee != null)
        {
            allEmployees.Remove(foundEmployee);
        }
        bool status = JsonFileManager.Save(filePath, allEmployees);
        return status;
    }
    
}

