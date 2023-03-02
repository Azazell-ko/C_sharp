/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. \
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

void PrintNumbers(int current)
{
   if (current > 1)
   {
      Console.Write($"{current}, ");
      PrintNumbers(current - 1);
   }
   else
      Console.Write($"{current}");
}

int GetN(string wlc_msg, string trash_err_msg, string less_err_msg)
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

int N = GetN("Введите N(натуральное число)", "Мусор в строке", "Введенное значение меньше 0");
PrintNumbers(N);