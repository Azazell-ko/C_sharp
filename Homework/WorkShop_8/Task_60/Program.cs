/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно 
выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int[,,] InitSuperMatrix(int m, int n, int l)
{
   int[,,] matrix = new int[m, n, l];
   Dictionary<int, bool> existence = new Dictionary<int, bool>();
   Random rnd = new Random();

   for (int i = 0; i < m; i++)
   {
      for (int j = 0; j < n; j++)
      {
         for (int k = 0; k < l; k++)
         {
            do
            {
               matrix[i, j, k] = rnd.Next(1, 100);
            }
            while(existence.ContainsKey(matrix[i, j, k]));
            existence[matrix[i, j, k]] = true;
         }
      }
   }

   return matrix;
}

void PrintSuperMatrix(int [,,] matrix)
{
   Console.WriteLine();
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      for (int j = 0; j < matrix.GetLength(2); j++)
      {
         for (int k = 0; k < matrix.GetLength(1); k++)
         {
            Console.Write($"{matrix[i, j, k]}({i}, {j}, {k}) ");
         }
         Console.WriteLine();
      }
   }
   Console.WriteLine();
}

int M = 2;
int N = 2;
int L = 2;

int [,,] matrix = InitSuperMatrix(M, N, L);
PrintSuperMatrix(matrix);