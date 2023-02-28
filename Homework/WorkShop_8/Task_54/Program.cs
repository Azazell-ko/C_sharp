/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
int[,] InitMatrix(int m, int n)
{
   int[,] matrix = new int[m, n];
   Random rnd = new Random();

   for (int i = 0; i < m; i++)
   {
      for (int j = 0; j < n; j++)
      {
         matrix[i, j] = rnd.Next(1, 10);
      }
      Console.WriteLine();
   }

   return matrix;
}

void PrintMatrix(int [,] matrix)
{
   Console.WriteLine();
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
         Console.Write($"{matrix[i, j]} ");
      }
      Console.WriteLine();
   }
   Console.WriteLine();
}

void SortMatrix(int [,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      for (int jo = 0; jo + 1 < matrix.GetLength(1); jo++)
      {
         for (int ji = 0; ji + 1 < matrix.GetLength(1) - jo; ji++)
         {
            if (matrix[i, ji + 1] > matrix[i, ji])
            {
               int tmp = matrix[i, ji + 1];
               matrix[i, ji + 1] = matrix[i, ji];
               matrix[i, ji] = tmp;
            }
         }
      }
   }
}

int M = 3;
int N = 4;

int [,] matrix = InitMatrix(M, N);
PrintMatrix(matrix);
SortMatrix(matrix);
PrintMatrix(matrix);