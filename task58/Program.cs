// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


int[,] firstMatrix = CreateMatrixRndInt(3, 2, 0, 5);
Console.WriteLine(" Первая матрица: ");
PrintMatrix(firstMatrix);

int[,] secondMatrix = CreateMatrixRndInt(2, 3, 0, 5);
Console.WriteLine(" Вторая матрица: ");
PrintMatrix(secondMatrix);

if (firstMatrix.GetLength(1) == secondMatrix.GetLength(0))
{
    int[,] multiMatrix = MatrixMultiplication(firstMatrix, secondMatrix);
    Console.WriteLine(" Итог умножения: ");
    PrintMatrix(multiMatrix);
}
else Console.WriteLine("Эти матрицы нельзя умножать");


int[,] MatrixMultiplication(int[,] matFirst, int[,] matSecond)
{
    int[,] multiMatrix = new int[matFirst.GetLength(0), matSecond.GetLength(1)];// матрица 2х2
    for (int i = 0; i < multiMatrix.GetLength(0); i++)//
    {
        for (int j = 0; j < multiMatrix.GetLength(1); j++)
        {
            for (int n = 0; n < matSecond.GetLength(0); n++)//  multiMatrix[0,1], n=0
            {
                multiMatrix[i, j] = multiMatrix[i, j] + (matFirst[i, n] * matSecond[n, j]);// =18
            }
        }

    }
    return multiMatrix;
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