int [] array = {16,23,4,83,52,61,77,83};

int n = array.Length;
int find = 83;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
