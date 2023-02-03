/*
Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).
*/


int GetNumber(string message)
{
    int resultNumber = 0;
    while(true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out resultNumber) && 0 < resultNumber && resultNumber < 5)
        {
            break;
        }
        else
        {
            Console.WriteLine("Введите корректный номер четверти");
        }
    }
    return resultNumber;
}
string GetQuarter(int V)
{
    if (V == 1)
    return "x > 0, y > 0";
    else if (V == 2)
    return "x < 0, y > 0";
    else if (V == 3)
    return "x < 0, y < 0";
    else 
    return "x > 0, y < 0";
    
}

int V = GetNumber("Введите четветь, от 1 до 4");

string quarter = GetQuarter(V);
Console.WriteLine($"В {V} четверти диапозон функии {quarter}");