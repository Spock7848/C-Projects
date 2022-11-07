// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*
Console.Write("Input the numbers separated by a space: ");
int[] numbers = StringToNum(Console.ReadLine()!);
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine($"The number of values greater than 0 is {sum}");


int[] StringToNum(string input)
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ' ')
        {
            count++;
        }
    }

    int[] numbers = new int [count];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string temp = "";

        while (input [i] != ' ')
        {
        if(i != input.Length - 1)
        {
            temp += input [i].ToString();
            i++;
        }
        else
        {
            temp += input [i].ToString();
            break;
        }
        }
        numbers[index] = Convert.ToInt32(temp);
        index++;
    }
    return numbers;
}
*/

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// Значения b1, k1, b2 и k2 задаются пользователем.

/*
Console.WriteLine("Input b1:");
double b1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input k1:");
double k1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input b2:");
double b2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input k2:");
double k2=Convert.ToInt32(Console.ReadLine());

double xIntersection = 0;
double yIntersection = 0;

if (b1==b2 & k1==k2) Console.WriteLine("The lines match");
else if (k1==k2) Console.WriteLine("The lines are parallel to each other");
else 
{
    xIntersection =(b2-b1)/(k1-k2);
    yIntersection =k1*xIntersection+b1;
    Console.WriteLine($"Intersection point ({xIntersection}; {yIntersection})");
}
*/