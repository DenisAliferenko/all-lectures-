// если мы хотим получить рандомное число можно ввести
int numberA = new Random().Next(1, 10); // даст любое число от 1 до 9
Console.WriteLine(numberA);

int numberB = new Random().Next(1, 10);
Console.WriteLine(numberB);

int result = numberA + numberB;
Console.WriteLine(result);
