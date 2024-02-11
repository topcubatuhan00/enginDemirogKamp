// ch-1

using Introduction.Business;
using Introduction.DataAccess.Concretes;
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

CourseManager courseManager = new(new CourseDal());
var courses = courseManager.GetAll();

for (int i = 0; i <courses.Count; i++)
{
    Console.WriteLine(courses[i].Id);
    Console.WriteLine(courses[i].Name);
    Console.WriteLine(courses[i].Description);
    Console.WriteLine(courses[i].Price);
}

Console.WriteLine("kod bitti");

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "12345679822";
customer1.FirstName = "Aslı";
customer1.LastName = "Karayiğit";
customer1.CustomerNumber = "11445522";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "56745679822";
customer2.FirstName = "Özgür";
customer2.LastName = "Atılgan";
customer2.CustomerNumber = "89745522";

CoorporateCustomer customer3 = new CoorporateCustomer();
customer3.Id = 3;
customer3.Name = "KodlamaIO";
customer3.CustomerNumber = "008989800";
customer3.TaxNumber = "234236346ı45";

CoorporateCustomer customer4 = new CoorporateCustomer();
customer4.Id = 4;
customer4.Name = "ABC";
customer4.CustomerNumber = "007789800";
customer4.TaxNumber = "87654523132";

string[] cities1 = {"Ankara","İstanbul","İzmir"};
string[] cities2 = {"Bursa","Bolu","Diyarbakır"};

cities1 = cities2;
Console.WriteLine(cities1[0]);

BaseCustomer[] customers = {customer1, customer2, customer3, customer4};

foreach (var item in customers)
{
    Console.WriteLine(item.CustomerNumber);
}
