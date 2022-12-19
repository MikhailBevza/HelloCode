int[] array = {1, 12, 31, 4, 35, 4, 77, 28};

int n = array.Length;

int find = 4;

int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }

    index++;
}
