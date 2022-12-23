string[] firstArray = new string[5] {"123", "23", "hello", "world", "res"};
string[] secondAarray = new string[firstArray.Length];
void Array(string[] firstArray, string[] secondArray)
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