# Конзолно приложение за управление на автосервиз
* Какъв проблем решаваме?
> Приложението позволява на потребителите да добавят, премахват, търсят и списват клиенти и техните автомобили, както и да управляват ремонти и услуги.
* Описание:
> Този клас "Customer" съдържа информация за клиента. Той включва четири свойства: CustomerID, FullName, PhoneNumber и Email. Конструкторът инициализира тези свойства.

![image](https://github.com/Loreta1x/Zadacha-5/assets/174993437/a839cedd-4a69-42a7-aa1d-d4d1223b7e0e)

> Класът "Car" съдържа информация за автомобила. Той включва пет свойства: CarID, Make, Model, Year и CustomerID. Конструкторът инициализира тези свойства.

![image](https://github.com/Loreta1x/Zadacha-5/assets/174993437/9a9f9cba-60fd-4b86-afec-cd18356773a3)

> Класът "Mechanic" съдържа информация за механика. Той включва три свойства: MechanicID, FullName и Specialization. Конструкторът инициализира тези свойства.

![image](https://github.com/Loreta1x/Zadacha-5/assets/174993437/6d4ed90e-7092-4aa5-80be-cc7009c6065f)

> Класът "Service" съдържа информация за услуга. Той включва три свойства: ServiceID, Description и Price. Конструкторът инициализира тези свойства.

![image](https://github.com/Loreta1x/Zadacha-5/assets/174993437/0d5e2477-526e-40c0-9f30-2e7d5f14b4e2)

> Класът "RepairOrder" съдържа информация за поръчка за ремонт. Той включва седем свойства: OrderID, CarID, MechanicID, Services, TotalPrice, OrderDate и IsCompleted. Конструкторът инициализира тези свойства.

![image](https://github.com/Loreta1x/Zadacha-5/assets/174993437/c753e328-bd2a-4fa0-8cea-19d43d78e8c5)

> Класът Garage съдържа списъци с обекти от тип Customer, Car, Mechanic, Service и RepairOrder. Той предоставя методи за добавяне, премахване, търсене и списване на тези обекти. В този клас се използwа и библиотеката Spectre.Console, за да се улесни създаването на интерфейса в конзолата.

![image](https://github.com/Loreta1x/Zadacha-5/assets/174993437/cc53073a-e4dc-4268-a767-480018528741)

> Методи в класа "Garage":

-> AddCustomer(Customer customer): Добавя нов клиент в списъка Customers.

-> RemoveCustomer(string customerID): Премахва клиент по уникален идентификатор.

-> SearchCustomerByName(string name): Търси клиент по име и връща първия намерен.

-> Get

-> ListAllCustomers(): Извежда списък с всички клиенти.

-> AddCar(Car car): Добавя нов автомобил в списъка Cars.

-> RemoveCar(string carID): Премахва автомобил по уникален идентификатор.

-> SearchCarByMake(string make): Търси автомобили по марка и връща списък с намерените автомобили.

-> ListAllCars(): Извежда списък с всички автомобили.

-> AddMechanic(Mechanic mechanic): Добавя нов механик в списъка Mechanics.

-> RemoveMechanic(string mechanicID): Премахва механик по уникален идентификатор.

-> AddService(Service service): Добавя нова услуга в списъка Services.

-> RemoveService(string serviceID): Премахва услуга по уникален идентификатор.

-> AddRepairOrder(RepairOrder order): Добавя нова поръчка за ремонт в списъка RepairOrders.

-> CompleteRepairOrder(string orderID): Завършва поръчка за ремонт по уникален идентификатор.

-> GenerateServiceReport(): Генерира отчет за всички поръчки за ремонт.

![image](https://github.com/Loreta1x/Zadacha-5/assets/174993437/c3b90a02-ca69-4c2d-b230-934af1df1230)

![image](https://github.com/Loreta1x/Zadacha-5/assets/174993437/a4cc26ce-fe01-4b66-a7a2-eec29de0c925)


