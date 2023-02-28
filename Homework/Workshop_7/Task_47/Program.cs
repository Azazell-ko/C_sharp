/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
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
         matrix[i, j] = rnd.Next(-9, 10);
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

int m = GetDimension("Введите m", "Мусор в строке");
int n = GetDimension("Введите n", "Мусор в строке");
int [,] matrix = InitMatrix(m, n);
PrintMatrix(matrix);