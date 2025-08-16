using MySql.Data.MySqlClient;

string connectionString = "server=localhost;port=3306;database=Employees;user=root;password=Mrunal@999";
MySqlConnection conn = new MySqlConnection(connectionString);
MySqlCommand cmd = new MySqlCommand("SELECT * FROM employee", conn);


try
{
    conn.Open();
    MySqlDataReader reader = cmd.ExecuteReader();




    while (reader.Read())
    {
        Console.WriteLine($"EmpId: {reader["EmpId"]}, EmpName: {reader["EmpName"]}, Salary: {reader["Salary"]}");
    }
    reader.Close();
}

catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}
finally
{
    conn.Close();
}


