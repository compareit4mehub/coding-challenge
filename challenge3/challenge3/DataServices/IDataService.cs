using challenge3.Models;
using System;
using System.Collections.Generic;

namespace challenge3.DataServices
{
    public interface IDataService
    {
        IEnumerable<Customer> GetAllCustomers();
        IEnumerable<PhoneNumber> GetAllPhoneNumbers();
        IEnumerable<PhoneNumber> GetPhoneNumbersByCustomerId(Guid customerId);
        int ActivatePhoneNumber(string phoneNumber);
    }
}