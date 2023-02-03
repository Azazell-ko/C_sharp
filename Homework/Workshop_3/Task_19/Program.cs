/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

Console.WriteLine("Введите пятизначное число");
string text = Console.ReadLine();

if (text[0] == text[4] && text[1] == text[3])
{
    Console.WriteLine("да");
}
else Console.WriteLine("нет");

