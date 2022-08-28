// для того чтобы  массив наполнился не нулями можем 
// воспользоваться методом void
void FillArray(int[] collection) // даем название данному массиву
{
    int length = collection.Length;
    int index = 0;
    while (index < length) // до тех пока индекс меньше длины массива
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int[10]; // определили что массив из 10 элементов
FillArray(array); // этот медот как раз и заполнил нам массив через Void
PrintArray(array); // этот метод нам распечатал массив 
