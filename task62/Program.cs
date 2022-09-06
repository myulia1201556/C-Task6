// Задача 62. Напишите программу, 
// которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

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

int i = 0; 
int j = 0; 
int temp = 1; 

while (temp <= matrix.GetLength(0) * matrix.GetLength(1))
{
    matrix[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= matrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > matrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

PrintArray(matrix);

void PrintArray (int[,] arr)
{
   for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      if (arr[i,j] / 10 <= 0)
      Console.Write($" {arr[i,j]} ");

      else Console.Write($"{arr[i,j]} ");
    }
    Console.WriteLine();
  }
} 


