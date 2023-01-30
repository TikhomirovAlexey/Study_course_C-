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

int[] GetMultiTwoDigit(int[] arr)
{
    int length = arr.Length / 2;
    if (arr.Length % 2 == 1) length = arr.Length / 2 + 1;
    int[] res = new int[length];
    for (int i = 0; i < length; i++)
    {
        if (i != arr.Length - 1 - i)
        {
            res[i] = arr[i] * arr[arr.Length - 1 - i];
        }
        else res[i] = arr[i];
    }
    return res;
}

int[] arrayNumbers = GenerateArray(9, 0, 10);
int[] multiTwoDigit = GetMultiTwoDigit(arrayNumbers);
Console.WriteLine($"В массиве {PrintArray(arrayNumbers)} произведение парных чисел равна {PrintArray(multiTwoDigit)}.");