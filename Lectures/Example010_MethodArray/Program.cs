int [] array = {1, 12, 18, 54, 35, 4, 17, 18};

int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index + 1;
    index ++;
}