using System;
using System.Collections.Generic;

namespace challenge3.Models
{
    public class Customer
    {
        public Guid Id { get; set; }
        public List<PhoneNumber> PhoneNumbers { get; set; }
    }
}