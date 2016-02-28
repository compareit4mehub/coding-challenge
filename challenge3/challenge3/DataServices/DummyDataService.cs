using challenge3.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace challenge3.DataServices
{
    public class DummyDataService : IDataService
    {
        private static Random _r = new Random();
        private static List<Customer> _customers = generateCustomers();

        private static List<Customer> generateCustomers()
        {
            List<Customer> customers = new List<Customer>();

            for (int i = 0; i < 50; ++i)
            {
                Customer customer = new Customer();
                customer.Id = Guid.NewGuid();

                //generate some phone numbers for the customer
                customer.PhoneNumbers = generatePhoneNumbers();

                customers.Add(customer);
            }

            return customers;
        }

        private static List<PhoneNumber> generatePhoneNumbers()
        {
            List<PhoneNumber> phoneNumbers = new List<PhoneNumber>();

            //give customer some phone numbers (min 1, max 3)
            int maxPhoneNumbers = _r.Next(1, 4);
            for (int i = 0; i < maxPhoneNumbers; ++i)
            {
                PhoneNumber phoneNumber = new PhoneNumber();
                phoneNumber.Number = "052" + _r.Next(1, 10000000).ToString("0000000");
                phoneNumber.Activated = _r.Next(5) == 0; //make about 20% active already

                phoneNumbers.Add(phoneNumber);
            }

            return phoneNumbers;
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            try
            {
                return _customers;
            }
            catch (Exception ex)
            {
                log(ex);
                return new List<Customer>();
            }
        }

        public IEnumerable<PhoneNumber> GetAllPhoneNumbers()
        {
            try
            {
                return _customers.SelectMany(c => c.PhoneNumbers);
            }
            catch (Exception ex)
            {
                log(ex);
                return new List<PhoneNumber>();
            }
        }

        public IEnumerable<PhoneNumber> GetPhoneNumbersByCustomerId(Guid customerId)
        {
            try
            {
                return _customers.Where(c => c.Id == customerId).SelectMany(c => c.PhoneNumbers);
            }
            catch (Exception ex)
            {
                log(ex);
                return new List<PhoneNumber>();
            }
        }

        public int ActivatePhoneNumber(string number)
        {
            try
            {
                PhoneNumber phoneNumber = _customers.SelectMany(c => c.PhoneNumbers).FirstOrDefault(pn => pn.Number == number);

                if (phoneNumber == null)
                {
                    return 2; //Phone number not found.
                }

                if (phoneNumber.Activated)
                {
                    return 1; //Phone number already activated.
                }

                phoneNumber.Activated = true;
                return 0; //Success

            }
            catch (Exception ex)
            {
                log(ex);
                return -1; //internal exception
            }
        }

        private void log(Exception exceptions)
        {

        }
    }
}