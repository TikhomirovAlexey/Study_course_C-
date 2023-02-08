// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7


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

int[] FindIndexMinNumber(int[,] matrix)
{
    int min = matrix[0, 0];
    int minRow = 0;
    int minColumn = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (min > matrix[i, j])
            {
                min = matrix[i, j];
                minRow = i;
                minColumn = j;
            }
        }
    }
    int[] arr = { minRow, minColumn };
    return arr;
}

int[,] GetMatrixNumbersAfterDel(int[,] matrix, int[] indexArr)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int row = 0;
    int col = 0;
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        if (row == indexArr[0]) row++;
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if (col == indexArr[1]) col++;
            newMatrix[i, j] = matrix[row, col];
            col++;
        }
        row++;
        col = 0;
    }
    return newMatrix;
}

int[,] matrixNumbers = GenerateMatrix(4, 4, 0, 20);
Console.WriteLine($"До удаления строк - \n{PrintMatrix(matrixNumbers)}");

int[] indexMinNumber = FindIndexMinNumber(matrixNumbers);

int[,] matrixNumbersAfterDel = GetMatrixNumbersAfterDel(matrixNumbers, indexMinNumber);
Console.WriteLine($"После удаления строк - \n{PrintMatrix(matrixNumbersAfterDel)}");