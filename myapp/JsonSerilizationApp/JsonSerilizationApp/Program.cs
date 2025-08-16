using System.Text.Json;
using System.IO;
using JsonSerilizationApp.Entities;

Employee employee1 = new Employee();
employee1.EmpName = "Mrunal Deshpade";
employee1.EmpId = 77;
employee1.Salary = 100000;

Employee employee2 = new Employee();
employee2.EmpName = "Shilpa Walhekar";
employee2.EmpId = 88;
employee2.Salary = 200000;

Employee employee3 = new Employee();
employee3.EmpName = "Mrunal Deshpade";
employee3.EmpId = 99;
employee3.Salary = 300000;


List<Employee> allEmployee = new List<Employee>();
allEmployee.Add(employee1);
allEmployee.Add(employee2);
allEmployee.Add(employee3);

String filePath = @"C:\Users\MrunalNandkumarDeshp\Desktop\Mrunal\Code\Employee.json";
String jsonString = JsonSerializer.Serialize(allEmployee);
File.WriteAllText(filePath, jsonString);
String retrievedJsonString = File.ReadAllText(filePath);
List<Employee> allRestoredEmployee = JsonSerializer.Deserialize<List<Employee>>(retrievedJsonString);

foreach(Employee retrivedEmployee in allRestoredEmployee)
{
    Console.WriteLine(retrivedEmployee.EmpName + " " + retrivedEmployee.EmpId + " " +retrivedEmployee.Salary);
}









