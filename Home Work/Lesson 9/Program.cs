// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

/*
int n = inputNum("Input a positive natural number: ");
int m = 1;
if (n < 1)
{
    Console.WriteLine("The number inputted is not positive.");
}
Console.WriteLine(naturalNum(n, m));

int naturalNum(int n, int m)
{
    if (n == m)
        return n;
    else
        Console.Write($"{naturalNum(n, m + 1)}, ");
    return m;
}

int inputNum(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine()!);
}
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

/*
int m = InputInt("Input M: ");
int n = InputInt("Input N: ");
Console.WriteLine($"Sum of elements between {m} and {n} is {CountNaturalSum(m, n)}");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine()!);
}

int CountNaturalSum(int m, int n)
{
    if (m == n)
        return n;
    return n + CountNaturalSum(m, n - 1);
}
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

/*
int M = InputInt("Input positive M: ");
int N = InputInt("Input positive N: ");
Console.WriteLine($"A({M}, {N}) = {Akkerman(M, N)}");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine()!);
}

int Akkerman(int M, int N)
{
    if (M == 0)
        return N + 1;
    if (M > 0 && N == 0)
        return Akkerman(M - 1, 1);
    else
        return Akkerman(M - 1, Akkerman(M, N - 1));
}
*/