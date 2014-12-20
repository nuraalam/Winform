using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using WindowsFormsApplication1.Model;

namespace WindowsFormsApplication1.UI
{
    internal class EmployeeGateway
    {
        private static SqlConnection connection;
        private static SqlCommand command;
        private static string query;

        private static void CallForConnection()
        {
            string conn = ConfigurationManager.ConnectionStrings["EmployeeDbContext"].ConnectionString;
            connection = new SqlConnection(conn);
            connection.ConnectionString = conn;

        }

        public void Save(Employee aEmployee)
        {

            CallForConnection();
            connection.Open();
            query = "INSERT INTO Employees (EmployeeName,Designation,ManagerId) Values(@0,@1,@2)";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@0", aEmployee.EmployeeName);
            command.Parameters.AddWithValue("@1", aEmployee.Designation);
            command.Parameters.AddWithValue("@2", aEmployee.ManagerId);
         
            command.ExecuteNonQuery();
            connection.Close();
        }

        public List<Employee> GetAllEmployee()
        {
            CallForConnection();
            connection.Open();
            query = String.Format("SELECT* FROM Employees");
            command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            List<Employee> employeeList = new List<Employee>();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    Employee aEmployee = new Employee();
                    aEmployee.EmployeeId = (int)aReader[0];
                    aEmployee.EmployeeName = aReader[1].ToString();
                    aEmployee.Designation = aReader[2].ToString();
                    aEmployee.ManagerId = aReader[3].ToString();
                    employeeList.Add(aEmployee);
                }
            }
            connection.Close();
            return employeeList;
        }
    }
}