/*Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Введите число");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);
for (int i = 1; i <= number; i++)
{
    int ost = i%2;
    if (ost == 0)
    {
        Console.Write(i + ", ");
    }
}