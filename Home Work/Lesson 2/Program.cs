// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
Console.Write("Input a three-digit number: ");
int n = Convert.ToInt32(Console.ReadLine());

if(n >= 100 && n < 1000)
{
    int secondDigit = n / 10 % 10;
    Console.WriteLine($"The second digit of {n} is: {secondDigit}");
}
else
{
    Console.WriteLine("Uncorrect input!");
}
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*
Console.WriteLine("Input a number with more than 2 digits: ");

int n = Convert.ToInt32(Console.ReadLine());
string nString = Convert.ToString(n);
if (nString.Length > 2)
{
    Console.WriteLine($"The third digit of {n} is: {nString[2]}");
}
else {
    Console.WriteLine("Uncorrect input!");
}
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*
Console.Write("Input a day week number: ");

int n = Convert.ToInt32(Console.ReadLine());

void dayWeekChecker (int n)
{
if (n == 6 || n == 7)
    {
    Console.WriteLine("This day is a day off");
    }
else if (n < 1 || n > 7) 
    {
    Console.WriteLine("Uncorrect input!");
    }
else Console.WriteLine("This day is not a day off");
}

dayWeekChecker(n);
*/