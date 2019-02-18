namespace WebApiProject.Models
{
    public interface IEmployee
    {
        int EmployeeId
        {
            get;
            set;
        }
        string EmployeeName
        {
            get;
            set;
        }

        string Department
        {
            get;
            set;
        }
    }
}