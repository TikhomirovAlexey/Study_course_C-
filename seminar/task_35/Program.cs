int[] GenerateArray(int length, int min, int max)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
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

int GetCountTwoDigit(int[] arr, int min, int max)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= min && arr[i] <= max) count++;
    }
    return count;
}

int[] arrayNumbers = GenerateArray(12, 0, 199);

int countTwoDigit = GetCountTwoDigit(arrayNumbers, 10, 99);
Console.WriteLine($"В массиве {PrintArray(arrayNumbers)} {countTwoDigit} двойных чисел(числа)");

