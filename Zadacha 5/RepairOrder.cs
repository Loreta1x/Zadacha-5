using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_5
{
    internal class RepairOrder
    {
        public string OrderID { get; set; }
        public string CarID { get; set; }
        public string MechanicID { get; set; }
        public List<Service> Services { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public bool IsCompleted { get; set; }

        public RepairOrder(string orderID, string carID, string mechanicID, List<Service> services, decimal totalPrice, DateTime orderDate, bool isCompleted)
        {
            OrderID = orderID;
            CarID = carID;
            MechanicID = mechanicID;
            Services = services;
            TotalPrice = totalPrice;
            OrderDate = orderDate;
            IsCompleted = isCompleted;
        }
    }
}
