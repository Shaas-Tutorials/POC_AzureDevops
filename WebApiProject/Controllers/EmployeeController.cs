using System.Collections.Generic;
using System.Web.Http;
using WebApiProject.Models;
using WebApiProject.SQL;

namespace WebApiProject.Controllers
{
    public class EmployeeController : ApiController
    {
        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = Database.GetEmployees();
            return employees;
        }
        public List<Employee> GetEmployeeDetails(int id)
        {
            List<Employee> employee = Database.GetEmployee(id);
            return employee;
        }

        //[System.Web.Http.HttpPost]
        //public string Post([FromBody] Employee emp)
        //{
        //    detailsController.employees.Add(emp);
        //    return "abc";
        //}
    }
}
