
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace challenge3.Models
{
    public class Customer
    {
        public Guid Id { get; set; }
        public List<PhoneNumber> PhoneNumbers { get; set; }
    }
}