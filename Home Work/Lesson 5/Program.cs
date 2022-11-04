// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

/*
Console.WriteLine("Enter size of the array");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int count = 0;

for (int a = 0; a < numbers.Length; a++)
if (numbers[a] % 2 == 0)
count++;

Console.WriteLine($"There ara(is) {numbers.Length} number(s), {count} of them are even");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*
Console.WriteLine("Enter size of the array");
int numberOfElements = Convert.ToInt32(Console.ReadLine()); 

int RandomNumbers(int numberOfElements, int min, int max)
  {
  int[] randomNumbers = new int[numberOfElements];
  int sumOfElements = 0;
  Console.Write("The resulting array: ");

    for (int i = 0; i <randomNumbers.Length; i++ ){
      randomNumbers[i] = new Random().Next(min, max);

      Console.Write(randomNumbers[i] + " ");

      if (i % 2 != 1)
      {
        sumOfElements = sumOfElements + randomNumbers[i];
      }
    }
  return sumOfElements;
  }

int randomNumbers =  RandomNumbers(numberOfElements, 1, 10);

Console.Write($"\nThe sum of elements in odd positions is {randomNumbers}");
*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

/*
Console.WriteLine("The array of real numbers");

int[] arrayRealNumbers = new int[10];
  for (int i = 0; i < arrayRealNumbers.Length; i++ )
  {
    arrayRealNumbers[i] = new Random().Next(1, 100);
    Console.Write(arrayRealNumbers[i] + " ");
  }

int maxN = arrayRealNumbers[0];
int minN = arrayRealNumbers[0];

  for (int i = 1; i < arrayRealNumbers.Length; i++)
  {
    if (maxN < arrayRealNumbers[i])
    {
      maxN = arrayRealNumbers[i];
    }
        if (minN > arrayRealNumbers[i])
    {
      minN = arrayRealNumbers[i];
    }
  }

  int decision = maxN - minN;

Console.WriteLine($"\nThe Difference between max({maxN}) and min({minN}) elements is {decision}");
*/