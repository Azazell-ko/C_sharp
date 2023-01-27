/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/
Console.WriteLine("Напишите цифру");
string text = Console.ReadLine();
int number = Convert.ToInt32(text);

if (number == 6)
{
    Console.WriteLine("да");
}
else if (number == 7)
{
    Console.WriteLine("да");
}
else Console.WriteLine("нет");
