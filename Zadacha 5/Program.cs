using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Garage garage = new Garage();
            while (true)
            {
                Console.WriteLine("1. Добави нов клиент");
                Console.WriteLine("2. Remove Customer");
                Console.WriteLine("3. Search Customer By Name");
                Console.WriteLine("4. List All Customers");
                Console.WriteLine("5. Add Car");
                Console.WriteLine("6. Remove Car");
                Console.WriteLine("7. Search Car By Make");
                Console.WriteLine("8. List All Cars");
                Console.WriteLine("9. Add Mechanic");
                Console.WriteLine("10. Remove Mechanic");
                Console.WriteLine("11. Add Service");
                Console.WriteLine("12. Remove Service");
                Console.WriteLine("13. Add Repair Order");
                Console.WriteLine("14. Complete Repair Order");
                Console.WriteLine("15. Generate Service Report");
                Console.WriteLine("16. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Customer ID:");
                        string customerID = Console.ReadLine();
                        Console.WriteLine("Enter Full Name:");
                        string fullName = Console.ReadLine();
                        Console.WriteLine("Enter Phone Number:");
                        string phoneNumber = Console.ReadLine();
                        Console.WriteLine("Enter Email:");
                        string email = Console.ReadLine();
                        Customer customer = new Customer(customerID, fullName, phoneNumber, email);
                        garage.AddCustomer(customer);
                        break;
                    case 2:
                        Console.WriteLine("Enter Customer ID:");
                        string removeCustomerID = Console.ReadLine();
                        garage.RemoveCustomer(removeCustomerID);
                        break;
                    case 3:
                        Console.WriteLine("Enter Customer Name:");
                        string searchName = Console.ReadLine();
                        var foundCustomer = garage.SearchCustomerByName(searchName);
                        if (foundCustomer != null)
                        {
                            Console.WriteLine($"Customer ID: {foundCustomer.CustomerID}, Name: {foundCustomer.FullName}, Phone: {foundCustomer.PhoneNumber}, Email: {foundCustomer.Email}");
                        }
                        else
                        {
                            Console.WriteLine("Customer not found.");
                        }
                        break;
                    case 4:
                        garage.ListAllCustomers();
                        break;
                    case 5:
                        Console.WriteLine("Enter Car ID:");
                        string carID = Console.ReadLine();
                        Console.WriteLine("Enter Make:");
                        string make = Console.ReadLine();
                        Console.WriteLine("Enter Model:");
                        string model = Console.ReadLine();
                        Console.WriteLine("Enter Year:");
                        int year = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Customer ID:");
                        string carCustomerID = Console.ReadLine();
                        Car car = new Car(carID, make, model, year, carCustomerID);
                        garage.AddCar(car);
                        break;
                    case 6:
                        Console.WriteLine("Enter Car ID:");
                        string removeCarID = Console.ReadLine();
                        garage.RemoveCar(removeCarID);
                        break;
                    case 7:
                        Console.WriteLine("Enter Car Make:");
                        string carMake = Console.ReadLine();
                        var carsByMake = garage.SearchCarByMake(carMake);
                        foreach (var c in carsByMake)
                        {
                            Console.WriteLine($"Car ID: {c.CarID}, Make: {c.Make}, Model: {c.Model}, Year: {c.Year}, Customer ID: {c.CustomerID}");
                        }
                        break;
                    case 8:
                        garage.ListAllCars();
                        break;
                    case 9:
                        Console.WriteLine("Enter Mechanic ID:");
                        string mechanicID = Console.ReadLine();
                        Console.WriteLine("Enter Full Name:");
                        string mechanicName = Console.ReadLine();
                        Console.WriteLine("Enter Specialization:");
                        string specialization = Console.ReadLine();
                        Mechanic mechanic = new Mechanic(mechanicID, mechanicName, specialization);
                        garage.AddMechanic(mechanic);
                        break;
                    case 10:
                        Console.WriteLine("Enter Mechanic ID:");
                        string removeMechanicID = Console.ReadLine();
                        garage.RemoveMechanic(removeMechanicID);
                        break;
                    case 11:
                        Console.WriteLine("Enter Service ID:");
                        string serviceID = Console.ReadLine();
                        Console.WriteLine("Enter Description:");
                        string description = Console.ReadLine();
                        Console.WriteLine("Enter Price:");
                        decimal price = decimal.Parse(Console.ReadLine());
                        Service service = new Service(serviceID, description, price);
                        garage.AddService(service);
                        break;
                    case 12:
                        Console.WriteLine("Enter Service ID:");
                        string removeServiceID = Console.ReadLine();
                        garage.RemoveService(removeServiceID);
                        break;
                    case 13:
                        Console.WriteLine("Enter Order ID:");
                        string orderID = Console.ReadLine();
                        Console.WriteLine("Enter Car ID:");
                        string orderCarID = Console.ReadLine();
                        Console.WriteLine("Enter Mechanic ID:");
                        string orderMechanicID = Console.ReadLine();
                        List<Service> orderServices = new List<Service>();
                        decimal totalPrice = 0;
                        while (true)
                        {
                            Console.WriteLine("Enter Service ID to add (or 'done' to finish):");
                            string serviceIDToAdd = Console.ReadLine();
                            if (serviceIDToAdd.ToLower() == "done")
                                break;
                            Service foundService = garage.Services.FirstOrDefault(s => s.ServiceID == serviceIDToAdd);
                            if (foundService != null)
                            {
                                orderServices.Add(foundService);
                                totalPrice += foundService.Price;
                            }
                            else
                            {
                                Console.WriteLine("Service not found.");
                            }
                        }
                        DateTime orderDate = DateTime.Now;
                        RepairOrder order = new RepairOrder(orderID, orderCarID, orderMechanicID, orderServices, totalPrice, orderDate, false);
                        garage.AddRepairOrder(order);
                        break;
                    case 14:
                        Console.WriteLine("Enter Order ID:");
                        string completeOrderID = Console.ReadLine();
                        garage.CompleteRepairOrder(completeOrderID);
                        break;
                    case 15:
                        garage.GenerateServiceReport();
                        break;
                    case 16:
                        return;
                }
            }
        }
    }
}

