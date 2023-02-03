/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/


int GetNumber(string message)
{
    int resultNumber = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out resultNumber))
        {
            break;
        }
        else
        {
            Console.WriteLine("Мусор в строке. Введите число. Повторите ввод!\n");
        }
    }
    return resultNumber;
}

int x1 = GetNumber("Введите координаты на оси х к первой точке");
int y1 = GetNumber("Введите координаты на оси y к первой точке");
int z1 = GetNumber("Введите координаты на оси z к первой точке");
int x2 = GetNumber("Введите координаты на оси х ко второй точке");
int y2 = GetNumber("Введите координаты на оси y ко второй точке");
int z2 = GetNumber("Введите координаты на оси z ко второй точке");

double distance = Math.Pow(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2), 0.5);
Console.WriteLine($"{distance:f2}");