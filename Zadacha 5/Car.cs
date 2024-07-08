using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_5
{
    internal class Car
    {
        public string CarID { get; set;}
        public string Make { get; set;}
        public string Model { get; set;}    
        public int Year { get; set;}
        public string CustomerID { get; set;}

        public Car (string carID, string make, string model, int year, string customerID)
        {
            CarID = carID;
            Make = make;
            Model = model;
            Year = year;
            CustomerID = customerID;
        }
    }
}
