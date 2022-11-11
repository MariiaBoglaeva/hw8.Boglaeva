// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)
int[,,] cube = CreateArray3D(4, 5, 5, 10, 99);
PrintMatrixWithIndex(cube);


int[,,] CreateArray3D(int row, int colum, int depth, int min, int max)
{
    int[,,] array3D = new int[row, colum, depth];
    int step = (max - min) / (row * colum * depth);
    if (step == 0) step = 1;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < colum; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                array3D[i, j, k] = min + step;
                min = array3D[i, j, k];
            }
        }
    }
    return array3D;

}

void PrintMatrixWithIndex(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j, k],4} ({i},{j},{k}), ");
                else Console.Write($"{matrix[i, j, k],4}({i},{j},{k})");
            }
        }
        Console.WriteLine("|");
    }
}