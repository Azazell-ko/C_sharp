/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
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


int A = GetNumber("Введите первое число A");
int B = GetNumber("Введите второе число B");

double pow = Math.Pow(A, B);
Console.WriteLine($"Число {A}, возведённое в степень {B} бедет равно {pow}");