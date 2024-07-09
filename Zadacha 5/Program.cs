using Spectre.Console;
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
                Console.WriteLine("2. Премахни клиент");
                Console.WriteLine("3. Търси клиент според името");
                Console.WriteLine("4. Виж всички клиенти");
                Console.WriteLine("5. Добави кола");
                Console.WriteLine("6. Премахни кола");
                Console.WriteLine("7. Търси кола според марката");
                Console.WriteLine("8. Виж всички коли");
                Console.WriteLine("9. Добави механик");
                Console.WriteLine("10. Премахни механик");
                Console.WriteLine("11. Добави услуга");
                Console.WriteLine("12. Премахни услуга");
                Console.WriteLine("13. Добави поръчка");
                Console.WriteLine("14. Завърши поръчка");
                Console.WriteLine("15. Генерирай отчет");
                Console.WriteLine("16. Изход");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Въведи Customer ID:");
                        string customerID = Console.ReadLine();
                        Console.WriteLine("Въведи пълно име:");
                        string fullName = Console.ReadLine();
                        Console.WriteLine("Въведи тел. номер:");
                        string phoneNumber = Console.ReadLine();
                        Console.WriteLine("Въведи имейл:");
                        string email = Console.ReadLine();
                        Customer customer = new Customer(customerID, fullName, phoneNumber, email);
                        garage.AddCustomer(customer);
                        break;
                    case 2:
                        Console.WriteLine("Въведи Customer ID:");
                        string removeCustomerID = Console.ReadLine();
                        garage.RemoveCustomer(removeCustomerID);
                        break;
                    case 3:
                        Console.WriteLine("Въведи името на клиента:");
                        string searchName = Console.ReadLine();
                        var foundCustomer = garage.SearchCustomerByName(searchName);
                        if (foundCustomer != null)
                        {
                            Console.WriteLine($"Customer ID: {foundCustomer.CustomerID}, Име: {foundCustomer.FullName}, Тел. номер: {foundCustomer.PhoneNumber}, Имейл: {foundCustomer.Email}");
                        }
                        else
                        {
                            Console.WriteLine("Клиентът не е намерен.");
                        }
                        break;
                    case 4:
                        garage.DisplayCustomersAsTable(garage.GetAllCustomers());
                        break;
                    case 5:
                        Console.WriteLine("Въведи Car ID:");
                        string carID = Console.ReadLine();
                        Console.WriteLine("Въведи марка:");
                        string make = Console.ReadLine();
                        Console.WriteLine("Въведи модел:");
                        string model = Console.ReadLine();
                        Console.WriteLine("Въведи година:");
                        int year = int.Parse(Console.ReadLine());
                        Console.WriteLine("Въведи Customer ID:");
                        string carCustomerID = Console.ReadLine();
                        Car car = new Car(carID, make, model, year, carCustomerID);
                        garage.AddCar(car);
                        break;
                    case 6:
                        Console.WriteLine("Въведи Car ID:");
                        string removeCarID = Console.ReadLine();
                        garage.RemoveCar(removeCarID);
                        break;
                    case 7:
                        Console.WriteLine("Въведи марката на автомобила:");
                        string carMake = Console.ReadLine();
                        var carsByMake = garage.SearchCarByMake(carMake);
                        foreach (var c in carsByMake)
                        {
                            Console.WriteLine($"Car ID: {c.CarID}, Марка: {c.Make}, Mодел: {c.Model}, Година: {c.Year}, Customer ID: {c.CustomerID}");
                        }
                        break;
                    case 8:
                        garage.DisplayCarsAsTable(garage.GetAllCars());
                        break;
                    case 9:
                        Console.WriteLine("Въведи Mechanic ID:");
                        string mechanicID = Console.ReadLine();
                        Console.WriteLine("Въведи пълно име:");
                        string mechanicName = Console.ReadLine();
                        Console.WriteLine("Въведи специализация:");
                        string specialization = Console.ReadLine();
                        Mechanic mechanic = new Mechanic(mechanicID, mechanicName, specialization);
                        garage.AddMechanic(mechanic);
                        break;
                    case 10:
                        Console.WriteLine("Въведи Mechanic ID:");
                        string removeMechanicID = Console.ReadLine();
                        garage.RemoveMechanic(removeMechanicID);
                        break;
                    case 11:
                        Console.WriteLine("Въведи Service ID:");
                        string serviceID = Console.ReadLine();
                        Console.WriteLine("Въведи описание на услугата:");
                        string description = Console.ReadLine();
                        Console.WriteLine("Въведи цена:");
                        decimal price = decimal.Parse(Console.ReadLine());
                        Service service = new Service(serviceID, description, price);
                        garage.AddService(service);
                        break;
                    case 12:
                        Console.WriteLine("Въведи Service ID:");
                        string removeServiceID = Console.ReadLine();
                        garage.RemoveService(removeServiceID);
                        break;
                    case 13:
                        Console.WriteLine("Въведи Order ID:");
                        string orderID = Console.ReadLine();
                        Console.WriteLine("Въведи Car ID:");
                        string orderCarID = Console.ReadLine();
                        Console.WriteLine("Въведи Mechanic ID:");
                        string orderMechanicID = Console.ReadLine();
                        List<Service> orderServices = new List<Service>();
                        decimal totalPrice = 0;
                        while (true)
                        {
                            Console.WriteLine("Въведи Service ID за да добавиш (или 'край' за да приключиш):");
                            string serviceIDToAdd = Console.ReadLine();
                            if (serviceIDToAdd.ToLower() == "край")
                                break;
                            Service foundService = garage.Services.FirstOrDefault(s => s.ServiceID == serviceIDToAdd);
                            if (foundService != null)
                            {
                                orderServices.Add(foundService);
                                totalPrice += foundService.Price;
                            }
                            else
                            {
                                Console.WriteLine("Услугата не е намерена");
                            }
                        }
                        DateTime orderDate = DateTime.Now;
                        RepairOrder order = new RepairOrder(orderID, orderCarID, orderMechanicID, orderServices, totalPrice, orderDate, false);
                        garage.AddRepairOrder(order);
                        break;
                    case 14:
                        Console.WriteLine("Въведи Order ID:");
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

