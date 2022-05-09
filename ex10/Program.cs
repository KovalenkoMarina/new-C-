int[] array = { 1, 2, 43, 72, 82, 3, 211, 93, 211 };

int n = array.Length;
int find = 211;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}