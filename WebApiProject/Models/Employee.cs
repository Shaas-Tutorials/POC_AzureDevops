namespace WebApiProject.Models
{
    public class Employee : IEmployee
    {
        public int EmployeeId { get; set ; }
        public string EmployeeName { get; set; }
        public string Department { get; set; }
	//bugfix
    }
}