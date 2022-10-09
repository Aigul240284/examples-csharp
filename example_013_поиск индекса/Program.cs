int[] array = {1,3,4,67,4147,4,7,521};
int n = array.Length;
int index = 0;
int find = 4;
while (index<n)
{
    if (array [index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;

}
