// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
int[,] squareMatrix = CreatDiagonalMatrix(5, 5);
PrintMatrix(squareMatrix);

int[,] CreatDiagonalMatrix(int row, int colum)
{
    int[,] matrix = new int[row, colum];
    int i = 0;
    int j = 0;
    int deltai = 0;
    int deltaj = 1;
    int maxi = row;
    int maxj = colum; //ограничитель (граница) для J
    int minj = 0;// ограничитель (граница) для J
    int mini = 1;
    for (int index = 1; index <= row * colum; index++)
    {
        matrix[i, j] = index;
        if (deltaj == 1 && j == maxj - 1)// идем вниз
        {
            deltai = 1;
            deltaj = 0;
            maxj--;
        }
        if (deltai == 1 && i == maxi - 1)// идем влево
        {
            deltai = 0;
            deltaj = -1;
            maxi--;
        }
        if (deltaj == -1 && j == minj)// идем вверх
        {
            deltai = -1;
            deltaj = 0;
            minj++;
        }
        if (deltai == -1 && i == mini)// идем вправо
        {
            deltai = 0;
            deltaj = 1;
            mini++;
        }
        i = i + deltai;
        j = j + deltaj;
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