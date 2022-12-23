string[] firstArray = new string[5] {"Ars", "MC", "Reds", "NU", "Spurs"};
string[] secondArray = new string[firstArray.Length];

void Top3PL2023(string[] firstArray, string[] secondArray)
{
    int count = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
    if(firstArray[i].Length <= 3)
        {
        secondArray[count] = firstArray[i];
        count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Top3PL2023(firstArray, secondArray);
PrintArray(secondArray);