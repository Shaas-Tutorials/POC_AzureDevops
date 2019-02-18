using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WebApiProject.Models;

namespace WebApiProject.SQL
{
    public class Connection
    { 
        public static void CreateConnection(SqlConnection myConnection)
        {
            try
            {
                myConnection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public static void CloseConnection(SqlConnection myConnection)
        {
            try
            {
                myConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public static List<Employee> ExecuteQuery(string query, SqlConnection myConnection)
        {
            List<Employee> employees = new List<Employee>();
            try
            {
                SqlCommand myCommand = new SqlCommand(query, myConnection);
                SqlDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    Employee emp = new Employee();
                    emp.EmployeeId = myReader.GetInt32(0);
                    emp.EmployeeName = myReader.GetString(1);
                    emp.Department = myReader.GetString(2);
                    employees.Add(emp);
                }
                myReader.ReadAsync().Result.ToString();
                string result = myReader.Read().ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return employees;
        }

        public static List<Address> ExecuteAddressQuery(string query, SqlConnection myConnection)
        {
            List<Address> addresses = new List<Address>();
            try
            {
                SqlCommand myCommand = new SqlCommand(query, myConnection);
                SqlDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    Address add = new Address();
                    add.HouseId = myReader.GetInt32(0);
                    add.HouseName = myReader.GetString(1);
                    addresses.Add(add);
                }
                myReader.ReadAsync().Result.ToString();
                string result = myReader.Read().ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return addresses;
        }
    }
}