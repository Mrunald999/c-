using HR.Entities;
using HR.Repository;
namespace HR.Services;


public class EmployeeService : IEmployeeService
{

    private readonly IEmployeeRepository _repo;

    public EmployeeService(IEmployeeRepository repo)
    {
        _repo = repo;
    }

    public List<Employee> GetAll()
    {
        return _repo.GetAll();
    }

    public Employee GetById(int EmpIdd)
    {
        return _repo.GetById(id);
    }

    public bool Add(Employee employee)
    {
        return _repo.Add(employee);
    }

    public bool Update(Employee employee)
    {
        return _repo.Update(employee);
    }

    public bool Remove(int EmpId)
    {
        return _repo.Remove(EmpId);
    }
}