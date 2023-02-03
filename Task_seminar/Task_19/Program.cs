/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4
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
        int kvadrat = index*index;
        Console.Write($"{kvadrat},  ");
    }
    int lastNumber = numberN*numberN;
    Console.Write($"{lastNumber}.");
}

int N = GetNumber("Введите число больше 0");
Pow(N);