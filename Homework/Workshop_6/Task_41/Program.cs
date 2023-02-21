/*
 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3

вводим через один Enter (разбиваем через Split())
*/

string Getdata()
{
    Console.WriteLine("Введите числа через ','");
    return Console.ReadLine();
}

string[] Parse(string data)
{
    string[] subs = data.Split(',');
    return subs;
}

int[] NumbersConvert(string[] text)
{
    int [] numbersMassiv = new int [text.Length];
    for(int index = 0; index < text.Length; index++)
    {
        if(!int.TryParse(text[index], out numbersMassiv[index]))
        {
        Console.WriteLine($" {text[index]}, Мусор в строке, введите числа через запятую");
        }
    }
    return numbersMassiv;
}

void resultat(int[] numbers)
{
    int count = 0;
    for(int index = 0; index < numbers.Length; index++)
    {

        if(numbers[index] > 0)
        {
            count++;            
        }
    }
    Console.Write(count);
}

string text = Getdata();
int[] numbers = NumbersConvert(Parse(text));
resultat(numbers);



