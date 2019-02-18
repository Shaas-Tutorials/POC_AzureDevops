using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiProject.Models;
using WebApiProject.SQL;

namespace WebApiProject.Controllers
{
    public class DetailsController : ApiController
    {
        public IList<Details> GetAllDetails()
        {
            //Return all employee details 
            IList<Details> details = new List<Details>();

            foreach (Employee employee in Database.GetEmployees())
            {
                Address address = Database.GetAddresses().FirstOrDefault(e => e.HouseId == employee.EmployeeId);
                Details detail = new Details
                {
                    EmployeeId = employee.EmployeeId,
                    Department = employee.Department,
                    HouseName = address.HouseName,
                    EmployeeName = employee.EmployeeName,
                    HouseId = address.HouseId
                };
                details.Add(detail);
            }
            return details;
        }
        public Details GetEmployeeDetails(int id)
        {
            //Return a single employee details  
            var employee = Database.GetEmployees().FirstOrDefault(e => e.EmployeeId == id);
            var address = Database.GetAddresses().FirstOrDefault(e => e.HouseId == id);
            Details detail = new Details
            {
                EmployeeId = id,
                Department = Database.GetEmployees().FirstOrDefault(e => e.EmployeeId == id).Department,
                HouseName = Database.GetAddresses().FirstOrDefault(e => e.HouseId == id).HouseName,
                EmployeeName = Database.GetEmployees().FirstOrDefault(e => e.EmployeeId == id).EmployeeName,
                HouseId = id
            };
            if (detail == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }
            return detail;
        }

        public Employee DeleteEmployeeDetail(int id)
        {
            //Return a single employee detail  
            var employee = Database.GetEmployees().FirstOrDefault(e => e.EmployeeId == id);
            var detail = Database.GetAddresses().FirstOrDefault(e => e.HouseId == id);

            if (employee == null || detail == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }
            else
            {
                Database.GetEmployees().Remove(employee);
                Database.GetAddresses().Remove(detail);
            }
            return employee;
        }

    }
}