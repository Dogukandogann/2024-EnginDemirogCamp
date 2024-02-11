﻿// See https://aka.ms/new-console-template for more information

using Intro.Business;
using Intro.DataAccess.Concretes;
using Intro.Entities;

Console.WriteLine("Hello, World!");

string message1 = "Krediler";
int term = 36;
double amount = 100000.5;
bool isAunthenticated = true;


Console.WriteLine(message1);

// Karar Yapıları
if (isAunthenticated) // Eğer isAunthenticated true ise
{
    Console.WriteLine("Buton --> Hoşgeldin Berkcan");
}
else
{
    Console.WriteLine("Buton --> Sisteme Giriş Yap.");
}




string[] loans = new string[] { "Kredi 1", "Kredi 2", "Kredi 3", "Kredi 4", "Kredi 5", "Kredi 6" };

for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}


Course course1 = new Course();
course1.Id = 1;
course1.Name = "C#";
course1.Description = ".NET 8";
course1.Price = 0;


Course course2 = new Course();
course2.Id = 2;
course2.Name = "Java";
course2.Description = "Java 17";
course2.Price = 10;

Course course3 = new Course();
course3.Id = 3;
course3.Name = "Python";
course3.Description = "Python 3.12";
course3.Price = 20;

Course[] courses = { course1, course2, course3 };



for (int i = 0; i < courses.Length; i++)
{
    Console.WriteLine(courses[i].Name + " / " + courses[i].Price);
}



CourseManager courseManager = new CourseManager(new CourseDal());
List<Course> courses2 = courseManager.GetAll();

for (int i = 0; i < courses2.Count; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}
courseManager.GetAll();


IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "12345678922";
customer1.FirstName = "Asıl";
customer1.Lastname = "Karayiğit";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "45125874588";
customer2.FirstName = "Özgür";
customer2.Lastname = "Atılgan";
customer2.CustomerNumber = "123457";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "CodlamaIO";
customer3.CustomerNumber = "5478545";
customer3.TaxNumber = "1234567891";
CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.Name = "Abc";
customer4.CustomerNumber = "5478549";
customer4.TaxNumber = "1234567897";

BaseCustomer[] customers = {customer1, customer2 ,customer3,customer4};

foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}