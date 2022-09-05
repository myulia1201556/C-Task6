// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2    В итоге получается вот такой массив:  7 4 2 1
// 5 9 2 3                                          9 5 3 2
// 8 4 2 4                                          8 4 4 2


Console.Clear();

Console.WriteLine("Введите число строк m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов n:");
int n = Convert.ToInt32(Console.ReadLine());

if (m == 0 || n == 0)
{
    Console.WriteLine("Невернозаданны параметры матрицы, попробуйте снова");
    return;
}
int[,] matrix = new int[m, n];
int[,] CreateMatrixRndDouble(int m, int n)
{

    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            matrix[i, j] = new Random().Next(0, 100);
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3},");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine("]");
    }
}

Console.WriteLine($"Двумерный массив m x n: ");
int[,] array2d = CreateMatrixRndDouble(m, n);
PrintMatrix(array2d);

Console.WriteLine();
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1) - 1; j++)
    {
        if (matrix[i, j] < matrix[i, j + 1])
        {
            int temp = 0;
            temp = matrix[i, j];
            matrix[i, j] = matrix[i, j + 1];
            matrix[i, j + 1] = temp;
        }

    }
}
Console.WriteLine($"Отсортированный массив имеет вид: ");
PrintMatrix(matrix);
