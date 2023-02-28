/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
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

bool CheckIdxs(int i, int j, int m, int n, bool[,] visit_matrix)
{
   return i >= 0 && j >= 0 && i < m && j < n && !visit_matrix[i, j];
}

string Next(string current)
{
   return new Dictionary<string, string>(){ 
      { "left", "down" },
      { "down", "right" }, 
      { "right", "up" },
      { "up", "left" }
   }[current];
}

void Traverse(int i, int j, int m, int n, int cnt, string move_type, int[,] matrix, bool[,] visit_matrix)
{
   matrix[i, j] = cnt++;
   visit_matrix[i, j] = true;
   var move_index_logic = new SortedDictionary<string, (int, int)>(){
      { "left", (0, 1) },
      { "down", (1, 0) }, 
      { "right", (0, -1) },
      { "up", (-1, 0) }
   };
   (int, int) index_offset = move_index_logic[move_type];
   int ni = i + index_offset.Item1;
   int nj = j + index_offset.Item2;
   int counter = 0;
   while(!CheckIdxs(ni, nj, m, n, visit_matrix) && ++counter < 3)
   {
      move_type = Next(move_type);
      index_offset = move_index_logic[move_type];
      ni = i + index_offset.Item1;
      nj = j + index_offset.Item2;
   }
   if (counter < 3)
      Traverse(ni, nj, m, n, cnt, move_type, matrix, visit_matrix);   
}

int[,] InitMatrix(int m, int n)
{
   int[,] matrix = new int[m, n];
   bool[,] visit_matrix = new bool[m, n];
   for (int i = 0; i < visit_matrix.GetLength(0); i++)
   {
      for (int j = 0; j < visit_matrix.GetLength(1); j++)
      {
         visit_matrix[i, j] = false;
      }
   }
   Random rnd = new Random();

   Traverse(0, 0, m, n, 1, "right", matrix, visit_matrix);

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

int m = GetDimension("Введите m", "Мусор в строке");
int n = GetDimension("Введите n", "Мусор в строке");
int [,] matrix = InitMatrix(m, n);
PrintMatrix(matrix);