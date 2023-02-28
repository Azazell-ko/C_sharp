/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
         Console.Write($"{matrix[i, j]} ");
      }
      Console.WriteLine();
   }
}

void FindPrintArithmeticAverage(int [,] matrix)
{
   int div = matrix.GetLength(1);
   for (int j = 0; j < matrix.GetLength(1); j++)
   {
      double avg = 0.0;
      for (int i = 0; i < matrix.GetLength(0); i++)
      {
         avg += (double)matrix[i, j]/(double)div;
      }
      Console.Write($"{avg:f1}; ");
   }
}

int M = 3;
int N = 4;

int [,] matrix = InitMatrix(M, N);
PrintMatrix(matrix);
FindPrintArithmeticAverage(matrix);