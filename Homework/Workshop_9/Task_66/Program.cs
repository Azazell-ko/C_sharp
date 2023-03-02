/* 
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int GetNumber(string wlc_msg, string trash_err_msg, string less_err_msg)
{
   int res_t = int.MaxValue;
   while(true)
   {
      Console.WriteLine(wlc_msg);
      if (int.TryParse(Console.ReadLine(), out res_t))
      {
         if (res_t < 0)
            Console.WriteLine(less_err_msg);
         else
            break;
      }
      else
         Console.WriteLine(trash_err_msg);
   }
   return res_t;
}

int Summ(int M, int N)
{
   Console.WriteLine($"{M} - {N}");
   return M + (M > N ? Summ(M - 1, N) : 0);
}

int M = GetNumber("Введите M(натуральное число)", "Мусор в строке", "Введенное значение меньше 0");
int N = GetNumber("Введите N(натуральное число)", "Мусор в строке", "Введенное значение меньше 0");

int summ = Summ(Math.Max(M, N), Math.Min(M, N));
Console.WriteLine($"Сумма -> {summ}");