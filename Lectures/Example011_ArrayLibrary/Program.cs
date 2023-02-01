void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    int find = 7;
    int count777 = 0;
    while (position < count)
    {
        Console.Write(col[position]);
        Console.Write(" ");
        if (col[position] == find)
            count777 ++;
        position++;                 
    }
    Console.WriteLine();     Console.WriteLine(count777);
}



int [] array = new int [10];
FillArray(array);
PrintArray(array);
