// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

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

void FlipArray(int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int temporaryVar = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temporaryVar;
    }
}

int[] arrayNumbers = GenerateArray(6, 0, 10);
Console.WriteLine(PrintArray(arrayNumbers));
FlipArray(arrayNumbers);
Console.WriteLine(PrintArray(arrayNumbers));