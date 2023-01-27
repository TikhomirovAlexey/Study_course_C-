// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

void GenerateArray(int[] arr, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
}

string PrintArray(int[] arr)
{
    string str = String.Empty;
    for (int i = 0; i < arr.Length; i++)
    {
        str += $"{arr[i]} ";
    }
    return str;

}

void RevertArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] != 0)
        {
            arr[i] = -arr[i];
        }

    }
}

int[] arrayNumbers = new int[12];
GenerateArray(arrayNumbers, -10, 10);
Console.WriteLine($"Сгенерированный массив: [{PrintArray(arrayNumbers)}]");

RevertArray(arrayNumbers);
Console.WriteLine($"Сгенерированный массив с заменой знака: [{PrintArray(arrayNumbers)}]");

