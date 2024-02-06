// See https://aka.ms/new-console-template for more information

using Intro.Business;
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

Console.WriteLine("------------------");
CourseManager courseManager = new CourseManager();
Course[] courses2 = courseManager.GetAll();
for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}
courseManager.GetAll();





