int[] array = { 1, 12, 18, 31, 24, 4, 14, 18 };

int n = array.Length; // указываем длину массива.

int find = 18;

int index = 0;

while (index < n)
{

    if ( array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
