namespace WebApiProject.Models
{
    public class Address : IAddress
    {
        public int HouseId { get; set; }
        public string HouseName { get; set; }
    }
}