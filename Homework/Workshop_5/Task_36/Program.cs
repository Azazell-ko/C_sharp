/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

void FillArray(int[] collection)
{
    var random = new Random(); 
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = random.Next(-99,100);
        index++;
    }
}

int CountEven(int[] numbers)
{
    int sum = 0;
    int lenght = numbers.Length;
    int index = 0;
    while (index < lenght)
    {
        if(index % 2 != 0)
        {
            sum += numbers[index];  // sum = sum + numbers[index];
        }
        index++;        
    }
    return sum;
}

int [] array = new int [4];

FillArray(array);

Console.Write("[{0}] -> {1}", string.Join(", ", array), CountEven(array));