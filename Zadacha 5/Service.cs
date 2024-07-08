using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_5
{
    internal class Service
    {
        public string ServiceID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public Service(string serviceID, string description, decimal price) 
        {
           ServiceID = serviceID;
            Description = description;
            Price = price;
        }

    }
}
