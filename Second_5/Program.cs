/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
456 -> 6
782 -> 2
918 -> 8
*/

Console.WriteLine("Введите число");
string number = Console.ReadLine();
int num = Convert.ToInt32(number);
int c=(num%100)%10;


Console.Write(c );