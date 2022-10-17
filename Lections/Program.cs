// Функции

/*
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int a1 = 15;
int b1 = 23;
int c1 = 414;
int a2 = 15;
int b2 = 23;
int c2 = 414;
int a3 = 15;
int b3 = 23;
int c3 = 234234;

//int max1 = Max(a1, b1, c1);   
//int max2 = Max(a2, b2, c2); 
//int max3 = Max(a3, b3, c3);

int max = Max(
    Max(a1, b1, c1),
    Max(a2, b2, c2),
    Max(a3, b3, c3));

Console.WriteLine(max);
*/

// Массивы

/*
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
//                0   1   2   3  4      5     6    7    8
int[] array = { 123, 23, 32, 45, 1, 23334, 5542, 156, 973 };

array[0] = 12;
Console.WriteLine(array[0]);

int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8]));

Console.WriteLine(max);
*/

// Пример 1. Поиск позиции нужного элемента.

/*
int[] array = { 123, 23, 32, 45, 1, 23334, 5542, 45, 156, 973 };

int n = array.Length;
int find = 45;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break; // Чтобы остановиться на первом попавшемся элементе
    }
    index++;
}
*/

// Пример 1 но с использованием ГСЧ и методов.

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
    }   index++;
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = index;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);