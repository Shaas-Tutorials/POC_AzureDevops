using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using WebApiProject.Models;

namespace WebApiProject.SQL
{
    public class Database
    {
        static readonly string connStr = ConfigurationManager.ConnectionStrings["sqlconnectionstring"].ConnectionString;
        public static List<Employee> GetEmployee(int empid)
        {
            SqlConnection myConnection = new SqlConnection(connStr);
            List<Employee> employees = new List<Employee>();
            Connection.CreateConnection(myConnection);
            string query = "select * from dbo.employee where EmployeeId = " + empid;
            employees = Connection.ExecuteQuery(query, myConnection);
            Connection.CloseConnection(myConnection);
            return employees;
        }
        internal static List<Employee> GetEmployees()
        {
            SqlConnection myConnection = new SqlConnection(connStr);
            List<Employee> employees = new List<Employee>();
            Connection.CreateConnection(myConnection);
            string query = "select * from dbo.employee";
            employees = Connection.ExecuteQuery(query, myConnection);
            Connection.CloseConnection(myConnection);
            return employees;
        }
        public static List<Address> GetAddress(int id)
        {
            SqlConnection myConnection = new SqlConnection(connStr);
            List<Address> addresses = new List<Address>();
            Connection.CreateConnection(myConnection);
            string query = "select * from dbo.address where HouseId = " + id;
            addresses = Connection.ExecuteAddressQuery(query, myConnection);
            Connection.CloseConnection(myConnection);
            return addresses;
        }


        internal static List<Address> GetAddresses()
        {
            SqlConnection myConnection = new SqlConnection(connStr);
            List<Address> addresses = new List<Address>();
            Connection.CreateConnection(myConnection);
            string query = "select * from dbo.address";
            addresses = Connection.ExecuteAddressQuery(query, myConnection);
            Connection.CloseConnection(myConnection);
            return addresses;
        }
    }
}