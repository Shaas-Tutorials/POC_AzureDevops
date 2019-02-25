using System.Collections.Generic;
using System.Web.Http;
using WebApiProject.Models;
using WebApiProject.SQL;

namespace WebApiProject.Controllers
{
    public class EmployeeController : ApiController
    {
        /// <summary>
        /// Retrieves all values from the list of employees
        /// </summary>
        /// <returns></returns>
        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = Database.GetEmployees();
            return employees;
        }

        /// <summary>
        /// Retrieves one value from the list of employees
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
