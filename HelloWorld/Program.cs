

// string myName = "Саша";
// int myAge = 18;
// string myGroup = "ИСП-242";

// Console.WriteLine($"Меня зовут {myName}, мне {myAge} лет, я учусь в группе {myGroup}.");


// Console.Write("Введите ваше имя: ");
// string name2 = Console.ReadLine();
// Console.WriteLine($"Привет, {name2}!");

// Console.Write("Введите ваш возраст: ");
// string input = Console.ReadLine();

// int age2 = int.Parse(input); 
// Console.WriteLine($"Через 10 лет вам будет {age2 + 10} лет.");


// int x = 10;
// int y = 3;
// Console.WriteLine(x + y); 
// Console.WriteLine(x - y); 
// Console.WriteLine(x * y); 
// Console.WriteLine(x / y); 
// Console.WriteLine(x % y); 

string firstName = "Саша";
string lastName = "Перехрест";
string group = "ИСП-242";
int birthYear = 2008;
double gpa = 4.8;
bool hasScholarship = true;
int currentYear = 2026;
int age = currentYear - birthYear;

Console.WriteLine("Студенческое удостоверение");
Console.WriteLine($"Имя: {firstName} {lastName}");
Console.WriteLine($"Группа: {group}");
Console.WriteLine($"Возраст: {age} лет");
Console.WriteLine($"Средний балл: {gpa}");
Console.WriteLine($"Стипендия: {hasScholarship}");


Console.Write("Введите ваш любимый предмет: ");
string subject = Console.ReadLine();
Console.WriteLine($"Отлично! {firstName} любит {subject}.");

