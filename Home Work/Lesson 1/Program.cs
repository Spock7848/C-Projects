// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*Console.WriteLine("Input two numbers: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 < num2) 
{
    Console.WriteLine(num2 + " is bigger then " + num1);
}
else if (num2 < num1)
{
    Console.WriteLine(num1 + " is bigger then " + num2);
}
else
{
    Console.WriteLine("Sorry, its equal ;(");
}*/


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*Console.WriteLine("Input three numbers: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;

if (num1 > num2 && num1 > num3)
{
    max = num1;
}
else if(num2 > num1 && num2 > num3)
{
    max = num2;
}
else
{
    max = num3;
}
Console.WriteLine("Max number is: " + max);
*/

// Долго мучался с попыткой вывода сообщения в случае повторяющихся максимальных чисел, но так ничего и не придумал.

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*Console.WriteLine("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("Even");
}
else
{
    Console.WriteLine("Odd");
}
*/

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*Console.WriteLine("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
int current = 1;

while(current<=num)
{
    if (current % 2 == 0)
    Console.WriteLine(current);
    current++;
}
*/
