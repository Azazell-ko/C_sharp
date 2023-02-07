/*
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

void FillArray(int[] collection)
{
    var random = new Random(); 
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = random.Next(100, 1000);
        index++;
    }
}

int CountEven(int[] numbers)
{
    int even = 0;
    int lenght = numbers.Length;
    int index = 0;
    while (index < lenght)
    {
        if(numbers[index] % 2 == 0)
        {
            even++;
        }
        index++;        
    }
    return even;
}

int [] array = new int [4];
FillArray(array);
Console.Write("[{0}]", string.Join(", ", array)); Console.Write(" -> "); Console.WriteLine(CountEven(array));
Console.Write("[{0}] -> {1}", string.Join(", ", array), CountEven(array));//Удобнее так 