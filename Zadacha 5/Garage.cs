using Spectre.Console;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_5
{
    internal class Garage
    {
        public List<Customer> Customers { get; set; } = new List<Customer>();
        public List<Car> Cars { get; set; } = new List<Car>();
        public List<Mechanic> Mechanics { get; set; } = new List<Mechanic>();
        public List<Service> Services { get; set; } = new List<Service>();
        public List<RepairOrder> RepairOrders { get; set; } = new List<RepairOrder>();

        public void AddCustomer(Customer customer)
        {
            Customers.Add(customer);
        }

        public void RemoveCustomer(string customerID)
        {
            Customers.RemoveAll(c => c.CustomerID == customerID);
        }

        public Customer SearchCustomerByName(string name)
        {
            return Customers.FirstOrDefault(c => c.FullName == name);
        }
        public List<Customer> GetAllCustomers() => Customers;

        public void ListAllCustomers() => DisplayCustomersAsTable(Customers);

        public void AddCar (Car car)
        {
            Cars.Add(car);
        }

        public void RemoveCar(string carID)
        {
            Cars.RemoveAll(c =>c.CarID == carID);
        }

        public List<Car> SearchCarByMake(string make)
        {
            return Cars.Where(c => c.Make == make).ToList();
        }

        public List<Car> GetAllCars() => Cars;

        public void ListAllCars() => DisplayCarsAsTable(Cars);

        public void AddMechanic(Mechanic mechanic)
        {
            Mechanics.Add(mechanic);
        }

        public void RemoveMechanic(string mechanicID)
        {
            Mechanics.RemoveAll(m => m.MechanicID == mechanicID);
        }

        public void AddService(Service service)
        {
            Services.Add(service);
        }

        public void RemoveService(string serviceID)
        {
            Services.RemoveAll(s => s.ServiceID == serviceID);
        }

        public void AddRepairOrder(RepairOrder order)
        {
            RepairOrders.Add(order);
        }

        public void CompleteRepairOrder(string  orderID)
        {
            var order = RepairOrders.FirstOrDefault(o => o.OrderID == orderID);
            if (order != null)
            {
                order.IsCompleted = true;
            }
        }

        public void GenerateServiceReport()
        {
            foreach(var order in RepairOrders.Where(o => o.IsCompleted))
            {
                Console.WriteLine($"Order ID: {order.OrderID}, Total Price: {order.TotalPrice}, Date: {order.OrderDate}");
            }
        }
        public void DisplayCustomersAsTable(List<Customer> customers)
        {
            var table = new Spectre.Console.Table();
            table.AddColumn("Customer ID");
            table.AddColumn("Full Name");
            table.AddColumn("Phone Number");
            table.AddColumn("Email");

            foreach (var customer in customers)
            {
                table.AddRow(customer.CustomerID, customer.FullName, customer.PhoneNumber, customer.Email);
            }

            Spectre.Console.AnsiConsole.Write(table);
        }

        public void DisplayCarsAsTable(List<Car> cars)
        {
            var table = new Spectre.Console.Table();
            table.AddColumn("Car ID");
            table.AddColumn("Make");
            table.AddColumn("Model");
            table.AddColumn("Year");
            table.AddColumn("Customer ID");

            foreach (var car in cars)
            {
                table.AddRow(car.CarID, car.Make, car.Model, car.Year.ToString(), car.CustomerID);
            }

            Spectre.Console.AnsiConsole.Write(table);
        }

    }
}
