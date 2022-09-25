// двумерная массив но через метод уже печатаем.

void PrintArray(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++ )
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
       Console.Write($" {matr [i, j]} ");
    }
Console.WriteLine();
}
}

void FillArray(int[,] matr)
{
    for(int i =0; i < matr.GetLength(0); i++)
    {
        for(int j =0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}
int[,] matrix1 = new int[3, 4];
PrintArray(matrix1);
FillArray(matrix1);
Console.WriteLine();

PrintArray(matrix1);
