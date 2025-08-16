namespace HR.Repository;

using HR.Entities;

public interface IEmployeeRepository
{
    public Employee GetByID(int EmpId);
    public List<Employee> GetAll();
    public bool Add(Employee employee);
    public Bool Update(Employee employee);
    public Bool Romove(int EmpId);
}