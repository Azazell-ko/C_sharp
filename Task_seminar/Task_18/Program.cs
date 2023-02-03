/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
*/

//A(2,1); B(2,6); C(3,6); Даны были А и С
// АС=корень(AB^2 + BC^2)       sqrt == корень
// Длинна AB = |Ay-By|      BC = |Bx - Cx|    AC = sqrt(|Ay-By|^2 + |Bx - Cx|^2)   
// Ах == Вх == х1 
// Ay == y1; 
// Cx == x2
// Cy == By == y2 
//  
//

double GetNumber(string message)
{
    double resultNumber = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(double.TryParse(Console.ReadLine(), out resultNumber) && resultNumber != 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число или не корректное число. Повторите ввод!\n");
        }
    }
    return resultNumber;
}

// Gip - гипотенуза =)
double Gip(double Bx, double Ay, double Cx, double By)
{
    double resultNumber = Math.Sqrt(Math.Pow(Ay - By, 2) + Math.Pow(Bx - Cx, 2));
    return resultNumber;
}

double x1 = GetNumber("Введите координаты на оси х к первой точке");
double y1 = GetNumber("Введите координаты на оси y к первой точке");
double x2 = GetNumber("Введите координаты на оси х ко второй точке");
double y2 = GetNumber("Введите координаты на оси y ко второй точке");

Console.WriteLine(Gip (x1, y1, x2, y2));