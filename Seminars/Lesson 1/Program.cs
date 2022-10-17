/*
Console.Write("Good evening everyone!");
Console.WriteLine("Good evening everyone!");
int n1 = 47;
double n2 = 32.15;
string name = "Nikita";
bool check = true;
Console.WriteLine(n2);
Console.WriteLine("My number is " + n1);
*/

/*
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Your number is " + num);
*/

// Задача 1. Напишите программу, которая на вход принимает 2 числа и проверяет, является ли первое число квадратом второго.
/*
Console.Write("Input a first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a secind number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

int q2 = n2 * n2;

if (n1 == q2)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
*/

// Задача 2. Напишите программу, которая на выход принимает число (N), а на выходе показывает числа от -N до N.

/*
Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());

int current = -n;

if(n < 0)
{
    current = n;
    n = -n;
}

while(current <= n)
{
    Console.Write(current + " ");
    current++;
}
*/

// Задача 3. Напишите программу, которая на вход принимает трехзначное число и на выходе показывает последнюю цифру этого числа.

/*
Console.Write("Input a three-digit number: ");
int n = Convert.ToInt32(Console.ReadLine());

if(n >= 100 && n <= 1000)
{
    int lastDigit = n % 10;
    Console.WriteLine("The last digit of " + n + " is: " + lastDigit);
    Console.WriteLine($"The last digit of {n} is: {lastDigit}");
}
else
{
    Console.WriteLine("Uncorrect input!");
}
*/