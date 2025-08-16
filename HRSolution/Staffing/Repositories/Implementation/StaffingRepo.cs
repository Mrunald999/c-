
using MySql.Data.MySqlClient;
using Staffing.Entities;
using Staffing.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Staffing.Repositories.Implementation
{
    public class StaffingRepo : IStaffingRepo
    {
        public bool AddEmployee(Employee employee)
        {
            bool status = false;
            string connectionString = "server=localhost; port=3306;database=Employees;user=root;password=Mrunal@999";
            List<Employee> employees = new List<Employee>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "INSERT INTO employee (EmpId,Name, Salary) VALUES (@EmpId,@Name, @Salary)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@EmpId", employee.EmpId);
                command.Parameters.AddWithValue("@Name", employee.Name);
                command.Parameters.AddWithValue("@Salary", employee.Salary);
                command.ExecuteNonQuery();
                status = true;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return status;
        }

        public bool DeleteEmployee(int EmpId)
        {
            bool status = false;
            string connectionString = "server=localhost; port=3306;database=Employees;user=root;password=Mrunal@999";
            List<Employee> employees = new List<Employee>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "DELETE FROM employee WHERE EmpId = @EmpId";
                MySqlCommand command = new MySqlCommand(query, connection);

                command.ExecuteNonQuery();
                status = true;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return status;
        }

        public bool UpdateEmployee(Employee employee)
        {
            bool status = false;
            string connectionString = "server=localhost; port=3306;database=Employees;user=root;password=Mrunal@999";
            List<Employee> employees = new List<Employee>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "UPDATE employee SET EmpName = @EmpName, Salary = @Salary WHERE EmpId = @EmpId";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@EmpId", employee.EmpId);
                command.ExecuteNonQuery();
                status = true;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return status;

        }
        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();
            string connectionString = "server=localhost; port=3306;database=Employees;user=root;password=Mrunal@999";
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "SELECT * FROM employee";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Employee employee = new Employee
                    {
                        EmpId = reader.GetInt32("EmpId"),
                        Name = reader.GetString("Name"),
                        Salary = reader.GetDouble("Salary")
                    };
                    employees.Add(employee);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return employees;

        }

        public Employee GetEmployeeById(int EmpId)

        {
            Employee employees = null;
            string connectionString = "server=localhost; port=3306;database;Employees;user=root;password=Mrunal@999";
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "SELECT * FROM employee WHERE EmpId = @EmpId";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@EmpId", EmpId);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    employees = new Employee
                    {
                        EmpId = reader.GetInt32("EmpId"),
                        Name = reader.GetString("Name"),
                        Salary = reader.GetDouble("Salary")
                    };

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();

            }
            return employees;
        }
    }
}
