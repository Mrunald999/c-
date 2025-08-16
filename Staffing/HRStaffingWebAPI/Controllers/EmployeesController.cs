using HRStaffingWebAPI.Entities;
using HRStaffingWebAPI.Repositories.Interfaces;
using HRStaffingWebAPI.Repositories.Implementation;
using HRStaffingWebAPI.Services.Implementation;
using HRStaffingWebAPI.Services.Intefaces;
using Microsoft.AspNetCore.Mvc;





// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HRStaffingWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        
        // GET: api/<Employees>
        [HttpGet]
        public IEnumerable<Employee> GetAllEmployees()
        {
            IHRStaffingRepo hrStaffingRepo = new HRStaffingRepo();
            IHrStaffingServices staffingService = new HrStaffingServices(hrStaffingRepo);
            List<Employee> employeeList = staffingService.GetAllEmployees();
            return employeeList;
        }

        // GET api/<Employees>/5
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            IHrStaffingServices staffingService = new HrStaffingServices(new HRStaffingRepo());
            Employee employee = staffingService.GetEmployeeByID(id);


            return employee;
        }

        // POST api/<Employees>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Employees>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Employees>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
