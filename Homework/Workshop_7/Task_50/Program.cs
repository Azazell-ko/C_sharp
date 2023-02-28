/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

пользователь вводит индексы 10, 10 - такого элемента нет.
пользователь вводите индексы 0, 2 - выводим элеменет 7
*/
int GetDimension(string wlc_msg, string trash_err_msg)
{
   int res_t = int.MaxValue;
   while(true)
   {
      Console.WriteLine(wlc_msg);
      if (int.TryParse(Console.ReadLine(), out res_t))
         break;
      else
         Console.WriteLine(trash_err_msg);
   }
   return res_t;
}

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

(int, int) ReadIndexes(int M, int N)
{
   int i = -1, j = -1;
   do
   {
      if (!(i == -1 && j == -1))
         Console.WriteLine("Такого элемента нет");
      i = GetDimension("Введите индекс M", "Мусор в строке");
      j = GetDimension("Введите индекс N", "Мусор в строке");
   }
   while (i >= M || j >= N);
   return (i, j);
}

int M = 3;
int N = 4;

int [,] matrix = InitMatrix(M, N);
PrintMatrix(matrix);

(int, int) idxs = ReadIndexes(M, N);
Console.WriteLine($"{matrix[idxs.Item1, idxs.Item2]}");