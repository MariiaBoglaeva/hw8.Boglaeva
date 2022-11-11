// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] matrix = CreateMatrixRndInt(3, 3, 0, 20);
Console.WriteLine("Исходный массив:");
PrintMatrix(matrix);
Console.WriteLine("ОтсортированныЙ массив");
SortMatrixRow(matrix);
PrintMatrix(matrix);

void SortMatrixRow(int[,] matrix)
{
    int jMax;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        jMax = 0;
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            jMax = j;
            for (int m = j + 1; m < matrix.GetLength(1); m++)
            {
                if (matrix[i, m] > matrix[i, jMax]) jMax = m;
            }
            int temp = matrix[i, j];
            matrix[i, j] = matrix[i, jMax];
            matrix[i, jMax] = temp;
        }
    }
}

int[,] CreateMatrixRndInt(int row, int colum, int min, int max)
{
    int[,] matrix = new int[row, colum];
    var rnd = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < colum; j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}