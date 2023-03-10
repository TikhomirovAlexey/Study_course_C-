// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.


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

string PrintDictionary(int[] unique, int[] count)
{
    string str = string.Empty;
    for (int i = 0; i < unique.Length; i++)
    {
        str += $"{unique[i],3} встречается {count[i]} раз(а).\n";
    }
    return str;

}

int[] GetArrayUniqueNumbers(int[,] matrix)
{
    int[] memoryNum = { matrix[0, 0] };
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            if (!memoryNum.Contains(matrix[i, j]))
            {
                Array.Resize(ref memoryNum, memoryNum.Length + 1);
                memoryNum[memoryNum.Length - 1] = matrix[i, j];
            }
        }
    }
    return memoryNum;
}

int[] GetSameCountNumbers(int[,] matrix, int[] arrUniqueNum)
{
    int[] tmpCount = new int[arrUniqueNum.Length];
    int indexArray = 0;
    tmpCount[indexArray] = 0;
    for (int k = 0; k < arrUniqueNum.Length; k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (arrUniqueNum[indexArray] == matrix[i, j]) tmpCount[indexArray]++;
            }

        }
        indexArray++;
    }
    return tmpCount;
}

int[,] matrixNumbers = GenerateMatrix(4, 4, 0, 10);
Console.WriteLine(PrintMatrix(matrixNumbers));

int[] arrayUniqueNumbers = GetArrayUniqueNumbers(matrixNumbers);
int[] sameCountNumbers = GetSameCountNumbers(matrixNumbers, arrayUniqueNumbers);
Console.WriteLine(PrintDictionary(arrayUniqueNumbers, sameCountNumbers));
