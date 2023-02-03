// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] GenerateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

string PrintMatrix(int[,] matrix)
{
    string str = string.Empty;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        str += "[";
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == matrix.GetLength(1) - 1) str += $" {matrix[i, j],3} ";
            else str += $" {matrix[i, j],3}, ";
        }
        str += "]\n";
    }
    return str;

}

bool ShowPresenceNumber(int[,] matrixNumbers, int userRow, int userCollumn)
{
    return userRow < matrixNumbers.GetLength(0) && userCollumn < matrixNumbers.GetLength(1);
}

int[,] matrixNumbers = GenerateMatrix(3, 4, -10, 10);
Console.WriteLine(PrintMatrix(matrixNumbers));

Console.WriteLine("Введите позицию элемента начиная с 0.");
Console.Write("Строка элемента: ");
int userRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Столбец элемента: ");
int userCollumn = Convert.ToInt32(Console.ReadLine());

while (userRow < 0 || userCollumn < 0)
{
    Console.WriteLine("Неверный ввод. Введите позицию элемента начиная с 0.");
    Console.Write("Строка элемента: ");
    userRow = Convert.ToInt32(Console.ReadLine());
    Console.Write("Столбец элемента: ");
    userCollumn = Convert.ToInt32(Console.ReadLine());
}

// if (userRow > matrixNumbers.GetLength(0) || userCollumn > matrixNumbers.GetLength(1)) Console.WriteLine("Такого элемента нет"); // вариант решения без метода
// else Console.WriteLine($"Элемент массива - {matrixNumbers[userRow, userCollumn]}");

bool presenceNumber = ShowPresenceNumber(matrixNumbers, userRow, userCollumn);
Console.WriteLine(presenceNumber ? $"Элемент массива - {matrixNumbers[userRow, userCollumn]}" : "Такого элемента нет");
