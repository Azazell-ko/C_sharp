/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

void FindMaxString(int [,] matrix)
{
   int max_idx = 0, max_val = int.MaxValue;
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      int summ = 0;
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
         summ += matrix[i, j];
      }
      if (summ < max_val)
      {
         max_val = summ;
         max_idx = i;
      }      
   }
   Console.WriteLine($"Наименьшая сумма элементов в строке {max_idx + 1}");
}

int M = 4;
int N = 4;

int [,] matrix = InitMatrix(M, N);
PrintMatrix(matrix);
FindMaxString(matrix);