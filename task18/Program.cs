// рекурсия и двумерные массивы
// сначала указываем тип данныхб 
// далее в квадратных скобках пишем запятую что указывает на размерность массива 
// далее наименование в нашем случае table
// 2 указывает количество строк а 3 указывает кол-во столбцов.
// string[,] table = new string[2,3];
//  пример с числами
//  int[,] matrix = new int[5,8]

string[,] table = new string[2,5];
table [0, 0] = "слово";

for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.Write($" - {table[rows, columns]}");
         
    }
    Console.WriteLine();
}

int[,] matrix = new int[3, 4];

for (int i = 0; i < 3; i++ )
{
    for (int j = 0; j < 4; j++)
    {
       Console.Write($" {matrix[i, j]} ");
    }
Console.WriteLine();
}

