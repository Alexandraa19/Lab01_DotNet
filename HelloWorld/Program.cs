

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

// string firstName = "Саша";
// string lastName = "Перехрест";
// string group = "ИСП-242";
// int birthYear = 2008;
// double gpa = 4.8;
// bool hasScholarship = true;
// int currentYear = 2026;
// int age = currentYear - birthYear;

// Console.WriteLine("Студенческое удостоверение");
// Console.WriteLine($"Имя: {firstName} {lastName}");
// Console.WriteLine($"Группа: {group}");
// Console.WriteLine($"Возраст: {age} лет");
// Console.WriteLine($"Средний балл: {gpa}");
// Console.WriteLine($"Стипендия: {hasScholarship}");


// Console.Write("Введите ваш любимый предмет: ");
// string subject = Console.ReadLine();
// Console.WriteLine($"Отлично! {firstName} любит {subject}.");

int a = 15;
int b = 4;

        Console.WriteLine($"Сумма: {a + b}");
        Console.WriteLine($"Разность: {a - b}");
        Console.WriteLine($"Произведение: {a * b}");
        Console.WriteLine($"Частное (int): {a / b}");
        Console.WriteLine($"Остаток: {a % b}");

        double result = (double)a / b;
        Console.WriteLine($"Частное (double): {result}");

        
        Console.WriteLine($"Модуль числа: {Math.Abs(-5)}");
        Console.WriteLine($"2 в степени 10: {Math.Pow(2, 10)}");
        Console.WriteLine($"Квадратный корень из 144: {Math.Sqrt(144)}");
        Console.WriteLine($"Максимум из 10 и 25: {Math.Max(10, 25)}");
        Console.WriteLine($"Минимум из 10 и 25: {Math.Min(10, 25)}");
        Console.WriteLine($"Округление 3.567 до 2 знаков: {Math.Round(3.567, 2)}");
        Console.WriteLine("Калькулятор");
Console.Write("Введите первое число: ");
double num1 = double.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
double num2 = double.Parse(Console.ReadLine());

Console.WriteLine($"Сумма: {num1 + num2}");
Console.WriteLine($"Разность: {num1 - num2}");
Console.WriteLine($"Произведение: {num1 * num2}");

if (num2 != 0)
{
    Console.WriteLine($"Частное: {num1 / num2}");
}
else
{
    Console.WriteLine("Деление на ноль невозможно!");
}

