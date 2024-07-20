using System;
using System.Data;
using System.Data.SqlClient;

namespace AdoNetDemo
{
    class Program
    {
        static string connectionString = "Server=localhost; Database=db_test; User Id=root; Password=;";

        static void Main(string[] args)
        {
            CreateEmployee("John Doe", "Developer", 60000);
            ReadEmployees();
            UpdateEmployee(1, "Jane Doe", "Senior Developer", 80000);
            ReadEmployees();
            DeleteEmployee(1);
            ReadEmployees();
        }

        static void CreateEmployee(string name, string position, decimal salary)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Employees (Name, Position, Salary) VALUES (@Name, @Position, @Salary)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Position", position);
                    command.Parameters.AddWithValue("@Salary", salary);
                    command.ExecuteNonQuery();
                }
            }
        }

        static void ReadEmployees()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Employees";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"ID: {reader["Id"]}, Name: {reader["Name"]}, Position: {reader["Position"]}, Salary: {reader["Salary"]}");
                        }
                    }
                }
            }
        }

        static void UpdateEmployee(int id, string name, string position, decimal salary)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Employees SET Name = @Name, Position = @Position, Salary = @Salary WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Position", position);
                    command.Parameters.AddWithValue("@Salary", salary);
                    command.ExecuteNonQuery();
                }
            }
        }

        static void DeleteEmployee(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Employees WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
