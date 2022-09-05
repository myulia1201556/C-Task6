// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке
//  и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

Console.WriteLine("Введите число строк m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов n:");
int n = Convert.ToInt32(Console.ReadLine());

if (m == 0 || n == 0)
{
    Console.WriteLine("Неверно заданны параметры матрицы, попробуйте снова");
    return;
}

int[,] matrix = new int[m, n];

int[,] CreateMatrixRndInt(int m, int n)
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
int numLine = 0;
int MinSumElem(int[,] matrix)
{
    int minsum = Int32.MaxValue;;
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        int sum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum += matrix[i, j];
        }
        if (sum < minsum)
        {
            minsum = sum;
            numLine++;
        }
    }
    return minsum;
}

Console.WriteLine($"Двумерный массив m x n: ");
int[,] array2d = CreateMatrixRndInt(m, n);
PrintMatrix(array2d);
Console.WriteLine();
int result = MinSumElem(matrix);
Console.WriteLine($"Строка {numLine} имеет минимальную сумму элементов = {result}");
