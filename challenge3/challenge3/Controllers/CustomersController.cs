using challenge3.DataServices;
using challenge3.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace challenge3.Controllers
{
    public class CustomersController : ApiController
    {
        IDataService _data = new DummyDataService();

        // GET: api/Customers
        public IEnumerable<Customer> Get()
        {
            return _data.GetAllCustomers();
        }
    }
}