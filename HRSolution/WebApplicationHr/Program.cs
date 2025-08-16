using Staffing.Entities;
using Staffing.Repositories;
using Staffing.Repositories.Implementation;
using Staffing.Services.Implementations;
using Staffing.Services.Intefaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.


app.MapGet("/api", () => "Welcome to Ecommerce App");
app.MapGet("/api/products",() =>
{
    IStaffingService staffingService = new StaffingService();
    List<Employee> employeeList = staffingService.GetAllEmployees();
    return employeeList;


});

app.Run();


