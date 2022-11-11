// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Наприер, задан массив:
// 1 4 7 2 = 14
// 5 9 2 3 = 19
// 8 4 2 4 = 18
// 5 2 6 7 = 20
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
int[,] matrix = CreateMatrixRndInt(3, 3, 0, 10);
Console.WriteLine("Исходный массив:");
PrintMatrix(matrix);
int[] sumRow = SumElementRow(matrix);
int numberMinSumRow = SearchIndexMinElement(sumRow);
Console.WriteLine($"Номер строки с наименьшей суммой элементов=> {numberMinSumRow+1}");


int[] SumElementRow(int[,] array2D)
{
    int[] sumArray = new int[array2D.GetLength(0)];
    for (int i = 0; i < sumArray.Length; i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            sumArray[i] = sumArray[i] + array2D[i, j];
        }
    }
    return sumArray;
}

int SearchIndexMinElement(int[] array)
{
    int min = array[0];
    int indexMin = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[1];
            indexMin = i;
        }
    }
    return indexMin;
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
