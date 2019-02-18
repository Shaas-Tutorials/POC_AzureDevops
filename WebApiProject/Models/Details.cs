namespace WebApiProject.Models
{
    public class Details : IEmployee, IAddress
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Department { get; set; }
        public int HouseId { get; set; }
        public string HouseName { get; set; }
    }
}