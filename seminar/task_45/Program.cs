// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int[] GenerateArray(int length, int min, int max)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

string PrintArray(int[] arr)
{
    string str = "[";
    for (int i = 0; i < arr.Length; i++)
    {
        if (str == "[") str += arr[i];
        else str += $", {arr[i]}";
    }
    str += "]";
    return str;

}

int[] MakeCopyArray(int[] arr)
{
    int[] temporaryArray = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        temporaryArray[i] = arr[i];
    }
    return temporaryArray;
}

int[] arrayNumbers = GenerateArray(6, 0, 10);
Console.WriteLine($"Начальный массив {PrintArray(arrayNumbers)}");
int[] copyArray = MakeCopyArray(arrayNumbers);
Console.WriteLine($"Скопированный массив {PrintArray(copyArray)}");