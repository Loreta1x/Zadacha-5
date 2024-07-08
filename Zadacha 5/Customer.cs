using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_5
{
    internal class Customer
    {
        public string CustomerID {  get; set; }
        public string FullName { get; set;}
        public string PhoneNumber { get; set;}
        public string Email { get; set;}

        public Customer (string customerID, string fullName, string phoneNumber, string email)
        {
            CustomerID = customerID;
            FullName = fullName;
            PhoneNumber = phoneNumber;
            Email = email;
        }

   

    }
}
