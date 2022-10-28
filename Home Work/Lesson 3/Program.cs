// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*
Console.Write("Input a five-digit number: ");
int number = Convert.ToInt32(Console.ReadLine()); 
int num1 = number / 10000 % 10;
int num2 = number / 1000 % 10;
int rev1 = number / 10 % 10;
int rev2 = number % 10;
int nul = number / 10000;
        
if (nul < 1 || nul > 9)
Console.WriteLine($"Number {number} is not a five-digit number");
else if  (num1 == rev2 && num2 == rev1)
Console.WriteLine($"Number {number} is a palindrom");
else
Console.WriteLine($"Number {number} is not a palindrom");
*/

// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*
int x1 = Coordinate("X", "A");
int y1 = Coordinate("Y", "A");
int z1 = Coordinate("Z", "A");
int x2 = Coordinate("X", "B");
int y2 = Coordinate("Y", "B");
int z2 = Coordinate("Z", "B");

int Coordinate(string coordinateName, string pointName)
{
    Console.Write($"Enter the {coordinateName} coordinate of {pointName}: ");
    return Convert.ToInt32(Console.ReadLine());
}

double Decision(double x1, double x2, 
                double y1, double y2, 
                double z1, double z2)
{
  return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                   Math.Pow((y2-y1), 2) + 
                   Math.Pow((z2-z1), 2));
}

double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"Segment length is {segmentLength}");
*/