/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

string GetNumber(string text)
{
    int resultNumber = 0;
    string resultNumberString = "";
    
    while(true)
    {
        Console.WriteLine(text); 
        resultNumberString = Console.ReadLine();
        if(int.TryParse(resultNumberString, out resultNumber) && resultNumber >= 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Мусор в строке. Введите положительное число. Повторите ввод.\n");
        }
    }
    return resultNumberString;
}

void numberS(string len)
{
    int sum = 0;
    for (int index = 0; index < len.Length; index++)
    {
        sum = sum + (len[index]-'0');  // '0' ASCII считаем расстояние от 0 по таблице аски. 
    }
    Console.WriteLine(sum);
}

string number = GetNumber("Введите положительное число");
numberS(number);
