// ch-1

using Introduction.Business;
using Introduction.Entities;

Console.WriteLine("Hello World!");

string message1 = "Krediler";
int term = 12;
double amount = 10000;

bool isAuthenticated = true;
Console.WriteLine(message1);

// ch-2

if (isAuthenticated)
    Console.WriteLine("Hoş geldin batu");
else
    Console.WriteLine("Giriş Yap");

string[] loans = { "Kredi 1", "Kredi 2", "Kredi 3", "Kredi 4" };

for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}

CourseManager courseManager = new();
var courses = courseManager.GetAll();

for (int i = 0; i <courses.Length; i++)
{
    Console.WriteLine(courses[i].Id);
    Console.WriteLine(courses[i].Name);
    Console.WriteLine(courses[i].Description);
    Console.WriteLine(courses[i].Price);
}

Console.WriteLine("kod bitti");