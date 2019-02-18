using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiProject.Models;
using WebApiProject.SQL;

namespace WebApiProject.Controllers
{
    public class AddressController : ApiController
    {
        public List<Address> GetAllAddress()
        {
            return Database.GetAddresses();
        }
        public List<Address> GetAddressDetails(int id)
        {
            List<Address> address = Database.GetAddress(id);
            if (address == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }
            return address;
        }
    }
}