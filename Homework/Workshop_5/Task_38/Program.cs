/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

void FillArray(double[] collection)
{
    var random = new Random(); 
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = Math.Round(random.NextDouble()*100, 2);        
        index++;
    }
}


double [] array = new double [5];
FillArray(array);
array.Max();
array.Min();
double diff = array.Max()-array.Min();


Console.Write("[{0}] -> {1:f2}", string.Join(", ", array), diff);
