using challenge3.DataServices;
using challenge3.Models;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace challenge3.Controllers
{
    public class PhoneNumbersController : ApiController
    {
        IDataService _data = new DummyDataService();

        // GET: api/PhoneNumbers
        public IEnumerable<PhoneNumber> Get()
        {
            return _data.GetAllPhoneNumbers();
        }

        // GET: api/PhoneNumbers/5652f002-e99a-4a1b-ae02-0cf86423b464
        public IEnumerable<PhoneNumber> Get(Guid id)
        {
            return _data.GetPhoneNumbersByCustomerId(id);
        }

        // PUT: api/PhoneNumbers/0524556567
        public int Put(string id)
        {
            return _data.ActivatePhoneNumber(id);
        }
    }
}