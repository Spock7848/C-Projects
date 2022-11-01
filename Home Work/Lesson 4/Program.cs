// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*
Console.Write("Input the A number: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the B number: ");
int B = Convert.ToInt32(Console.ReadLine());

int exp(int A, int B)
{
int result = 1;
  for(int i=1; i <= B; i++)
  {
    result = result * A;
  }
    return result;
}

int expResult = exp(A, B);
Console.WriteLine("Exponentiation result: " + expResult);
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int number)
  {
    
    int counter = Convert.ToString(number).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
      advance = number - number % 10;
      result = result + (number - advance);
      number = number / 10;
    }
   return result;
  }

int sumNumber = SumNumber(number);
Console.WriteLine("The sum of the digits in a number: " + sumNumber);
*/