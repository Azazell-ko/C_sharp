/*Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine("Введите любое число");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);
int ost = number%2;
if (ost != 0)
{
    Console.WriteLine("нет");
}
if (ost == 0)
{
    Console.WriteLine("да");
}