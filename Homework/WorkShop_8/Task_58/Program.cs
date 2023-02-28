/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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

int[,] MatrixMultiply(int[,] matrix1, int[,] matrix2)
{
   int m1M = matrix1.GetLength(0);
   int m1N = matrix1.GetLength(1);
   int m2M = matrix2.GetLength(0);
   int m2N = matrix2.GetLength(1);
   int nwM = m1M;
   int nwN = m2N;
   System.Diagnostics.Trace.Assert(m1N == m2M);
   int[,] matrix = new int[nwM, nwN];

   for (int i = 0; i < nwM; i++)
   {
      for (int j = 0; j < nwN; j++)
      {
         for (int d = 0; d < m1N; d++)
            matrix[i, j] += matrix1[i, d]*matrix2[d, j];
      }
   }

   return matrix;
}

int M = 2;
int N = 2;

int [,] matrix1 = InitMatrix(M, N);
int [,] matrix2 = InitMatrix(N, M);
int [,] matrix3 = MatrixMultiply(matrix1, matrix2);
PrintMatrix(matrix1);
PrintMatrix(matrix2);
PrintMatrix(matrix3);