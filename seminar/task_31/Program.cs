// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

void GenerateArray(int[] arr, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine("");
}

// void GetSum(int[] arr)
// {
//     int negSum = 0;
//     int posSum = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] < 0) negSum += arr[i];
//         else posSum += arr[i];
//     }
//     PrintSum(negSum, posSum);
// }

// void PrintSum(int negS, int posS)
// {
//     Console.WriteLine($"Сумма отрицательных чисел: {negS}. Сумма положительных чисел: {posS}.");
// }

int GetSum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sum += arr[i];
    }
    return sum;
}

int GetNegSum(int[] arr)
{
    int negSum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) negSum += arr[i];
    }
    return negSum;
}



int[] arrayNumbers = new int[12];
GenerateArray(arrayNumbers, -9, 9);
PrintArray(arrayNumbers);
Console.WriteLine($"Сумма отрицательных чисел: {GetSum(arrayNumbers)}. Сумма положительных чисел: {GetNegSum(arrayNumbers)}.");
