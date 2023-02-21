/*
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

(double, double) FindIntersection(in double k1, in double b1, in double k2, in double b2)
{
   double xi = (b2 - b1)/(k1 - k2);
   double yi = (k1*b2 - k2*b1)/(k1 - k2);
   return (xi, yi);
}

double GetPoint(in string wlc_msg, in string trash_err_msg)
{
   double res_t = int.MaxValue;
   while(true)
   {
      Console.WriteLine(wlc_msg);
      if (double.TryParse(Console.ReadLine(), out res_t))
         break;
      else
         Console.WriteLine(trash_err_msg);
   }
   return res_t;
}

double b1 = GetPoint("Введите b1", "Мусор в строке");
double k1 = GetPoint("Введите k1", "Мусор в строке");
double b2 = GetPoint("Введите b2", "Мусор в строке");
double k2 = GetPoint("Введите k2", "Мусор в строке");
(double, double) point = FindIntersection(k1, b1, k2, b2);
Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({point.Item1}, {point.Item2})");