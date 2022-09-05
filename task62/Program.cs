// Задача 62. Напишите программу, 
// которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// void Main(string[] args)
// {
//     int N = 3, M = 3;
//     var a = CreateSnakeArrayVsClock(N, M);

//     for (int i = 0; i < N; i++)
//     {
//         for (int j = 0; j < M; j++)
//         {
//             Console.Write(a[i, j] + " ");
//         }
//         Console.WriteLine();
//     }


//     Console.ReadKey();
// }

// int[,] CreateSnakeArrayVsClock(int n, int m)
// {
//     var arr = CreateSnakeArray(n, m);
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n / 2; j++)
//         {
//             var tmp = arr[i, j];
//             arr[i, j] = arr[i, m - j - 1];
//             arr[i, m - j - 1] = tmp;
//         }
//     }
//     return arr;
// }

// int[,] CreateSnakeArray(int n, int m)
// {
//     int[,] A = new int[n, m];
//     int row = 0, col = 0, dx = 1, dy = 0, dirChanges = 0, gran = m;

//     for (int i = 0; i < A.Length; i++)
//     {
//         A[col, row] = i + 1;
//         if (--gran == 0)
//         {
//             gran = m * (dirChanges % 2) + n * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
//             int temp = dx;
//             dx = -dy;
//             dy = temp;
//             dirChanges++;
//         }
//         col += dx;
//         row += dy;
//     }
//     return A;
// }
    
int N = 4, M = 4;
            int[,] A = new int[N, M];
 
            int row = 0, col = 0, dx = 1, dy = 0, dirChanges = 0, gran = M;
 
            for (int i = 0; i < A.Length; i++)
            {
                A[col, row] = i + 1;
                if (--gran == 0)
                {
                    gran = M * (dirChanges % 2) + N * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
                    int temp = dx;
                    dx = -dy;
                    dy = temp;
                    dirChanges++;
                }
                col += dx;
                row += dy;
            }
 
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }
 
            Console.ReadKey();
