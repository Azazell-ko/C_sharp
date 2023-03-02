/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
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

(double, double) AckermannAngles(int m, int n)
{
   return (Math.Atan(0.5*m/n)/Math.PI*180, Math.Atan(n/(0.5*m))/Math.PI*180);
}

int Ackermann(int m, int n)
{
   if (m == 0)
      return n + 1;
   else if (n == 0)
      return Ackermann(m - 1, 1);
   else
      return Ackermann(m - 1, Ackermann(m, n - 1));
}

int M = GetNumber("Введите M(натуральное число)", "Мусор в строке", "Введенное значение меньше 0");
int N = GetNumber("Введите N(натуральное число)", "Мусор в строке", "Введенное значение меньше 0");

int ack = Ackermann(M, N);
Console.WriteLine($"Функция Аккермана -> {ack}");
//(double, double) ackAngles = AckermannAngles(M, N);
//Console.WriteLine($"Углы Аккермана -> {ackAngles.Item1:f2};{ackAngles.Item2:f2}");