/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

Console.WriteLine("Напишите число");
string text = Console.ReadLine();
if (text.Length >= 3)
{
    char a = text[2];
    Console.WriteLine("Третья цифра - {0}", a);
}
else 
    Console.WriteLine("Третьей цифры нет");