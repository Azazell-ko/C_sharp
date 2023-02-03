/*
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int GetNumber(string message)
{
    int resultNumber = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out resultNumber) && resultNumber > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Введите число > 0. Повторите ввод!\n");
        }
    }
    return resultNumber;
}


void Pow(int numberN)
{
    for(int index = 1; index < numberN; index++)
    {
        double kub = Math.Pow(index, 3);
        Console.Write($"{kub},  ");
    }
    double lastNumber = Math.Pow(numberN, 3);
    Console.Write($"{lastNumber}");
}

int N = GetNumber("Введите число больше 0");
Pow(N);