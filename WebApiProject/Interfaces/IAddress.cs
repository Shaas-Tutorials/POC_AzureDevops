namespace WebApiProject.Models
{
    public interface IAddress
    {
        int HouseId
        {
            get;
            set;
        }
        string HouseName
        {
            get;
            set;
        }
    }
}