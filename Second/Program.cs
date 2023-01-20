/*
Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное
на само себя).

Например:
4 -> 16
-3 -> 9
-7 -> 49
*/

Console.WriteLine("Введите число:");
string numberStr = Console.ReadLine(); // 22-> "22"
int number = Convert.ToInt32(numberStr); // 22\

int result = number * number;

Console.WriteLine($"квадрат числа {number} = {result}");
Console.WriteLine("квадрат числа{number} = {result}");
Console.WriteLine("квадрат числа {0} = {1}", number, result);
Console.WriteLine("квадрат числа " + number + " = " + result);
