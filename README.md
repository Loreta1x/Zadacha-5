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

-> GetAllCostumers():  Връща всички клиенти в списъка.

-> ListAllCustomers(): Извежда всички клиенти в конзолата като таблица.

-> AddCar(Car car): Добавя нов автомобил в списъка Cars.

-> RemoveCar(string carID): Премахва автомобил по уникален идентификатор.

-> SearchCarByMake(string make): Търси автомобили по марка и връща списък с намерените автомобили.

-> GetAllCars: Връща всички коли в списъка.

-> ListAllCars(): Извежда всички автомобили в конзолата като таблица.

-> AddMechanic(Mechanic mechanic): Добавя нов механик в списъка Mechanics.

-> RemoveMechanic(string mechanicID): Премахва механик по уникален идентификатор.

-> AddService(Service service): Добавя нова услуга в списъка Services.

-> RemoveService(string serviceID): Премахва услуга по уникален идентификатор.

-> AddRepairOrder(RepairOrder order): Добавя нова поръчка за ремонт в списъка RepairOrders.

-> CompleteRepairOrder(string orderID): Завършва поръчка за ремонт по уникален идентификатор.

-> GenerateServiceReport(): Генерира отчет за всички поръчки за ремонт.

-> DisplayCustomersAsTable: Извежда данни за клиентите в конзолата във форматирана таблица.

-> DisplayCarsAsTable: Извежда данни за колите в конзолата във форматирана таблица.

![image](https://github.com/Loreta1x/Zadacha-5/assets/174993227/ff6f2d83-8f26-4d1d-b117-2c19f00fb20d)

![image](https://github.com/Loreta1x/Zadacha-5/assets/174993227/611da3e7-49b9-4425-b063-f32cb3b37296)

![image](https://github.com/Loreta1x/Zadacha-5/assets/174993227/73affaf1-ed6d-469a-9e3c-319bc52872dc)

> Класът Program в този контекст служи като интерфейс за взаимодействие с класа Garage, като осигурява потребителски интерфейс чрез конзола за различни операции с клиенти, коли, механици, услуги и поръчки за ремонт.
> Създава се нов обект от тип Garage, който ще съдържа списъците с клиенти, коли, механици, услуги и поръчки за ремонт.
> Цикълът while (true) се изпълнява постоянно, докато потребителят не избере опция 16 (Изход).
> Чете се изборът на потребителя чрез Console.ReadLine() и се преобразува в цяло число (int choice).
> Използва се switch конструкция, за да се извърши съответната операция в зависимост от избора на потребителя.
> Операции с клиенти: Добавяне на нов клиент (case 1), Премахване на клиент (case 2), Търсене на клиент по име (case 3), Извеждане на всички клиенти като таблица (case 4)
> Операции с коли: Добавяне на нова кола (case 5), Премахване на кола (case 6), Търсене на коли по марка (case 7), Извеждане на всички коли като таблица (case 8)
> Операции с механици: Добавяне на нов механик (case 9), Премахване на механик (case 10)
> Операции с услуги: Добавяне на нова услуга (case 11), Премахване на услуга (case 12)
> Операции с поръчки за ремонт: Добавяне на нова поръчка за ремонт (case 13), Завършване на поръчка за ремонт (case 14)
> Генериране на отчет (case 15) и Изход от програмата (case 16)

![image](https://github.com/Loreta1x/Zadacha-5/assets/174993227/6f88a3fc-b1ac-4c91-a179-f0e3504565d9)

![image](https://github.com/Loreta1x/Zadacha-5/assets/174993227/76c8af9b-8702-43eb-b669-35cfa128e843)

![image](https://github.com/Loreta1x/Zadacha-5/assets/174993227/b615218e-b791-454a-89bc-b5fab4cea2cb)

* Демонстрация на кода:

![image](https://github.com/Loreta1x/Zadacha-5/assets/174993227/de432c6e-4747-4967-b961-744ab25cf40b)

* Връзка към кода:

[Source Code](Zadacha-5/Zadacha 5
/Program.cs
)



