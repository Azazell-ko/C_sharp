/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите первое число");
string numberStr1 = Console.ReadLine();
Console.WriteLine("Введите второе число");
string numberStr2 = Console.ReadLine();
Console.WriteLine("Введите третье число");
string numberStr3 = Console.ReadLine();
int number1 = Convert.ToInt32(numberStr1);
int number2 = Convert.ToInt32(numberStr2);
int number3 = Convert.ToInt32(numberStr3);
if (number1 > number2)
{
    if (number3 > number1)
    {
        Console.WriteLine($"max = {number3}");
    }
    if (number3 < number1)
    {
        Console.WriteLine($"max = {number1}");
    }
}
if (number1 < number2)
{
    if (number3 > number2)
    {
        Console.WriteLine($"max = {number3}");
    }
    if (number3 < number2)
    {
        Console.WriteLine($"max = {number2}");
    }
}