// Задача 58: Задайте две матрицы.
// Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите число строк r:");
int r = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов c:");
int c = Convert.ToInt32(Console.ReadLine());

Random rnd = new Random();
int[,] CreateMatrix(int row, int col)
{
    int[,] matrix = new int[row, col];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 9);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}");
            else Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine("]");
    }
}
int[,] ProductMatrix(int[,] matrix1, int[,] matrix2)
{
    var matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        for (int i = 0; i < matrix3.GetLength(0); i++)
        {
            for (int j = 0; j < matrix3.GetLength(1); j++)
            {
                matrix3[i, j] = 0;
                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
    }
    return matrix3;
}

int[,] matrix = CreateMatrix(rnd.Next(r, c), rnd.Next(r, c));
int[,] matrix2 = CreateMatrix(rnd.Next(r, c), rnd.Next(r, c));
PrintMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine($"Результрущая матрица выглядит так: ");
PrintMatrix(ProductMatrix(matrix, matrix2));
Console.ReadLine();
