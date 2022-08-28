/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет */
Random rand = new Random();
int m = new Random().Next(0, 10);
int n = new Random().Next(0, 10);
int[,] matrix = new int [m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        Console.Write($"{matrix[i, j] + " "}");
    }
    Console.WriteLine();
}
Console.WriteLine("Введите a: ");
int a = Convert.ToInt32(Console.ReadLine()) - 1;
Console.WriteLine("Введите b: ");
int b = Convert.ToInt32(Console.ReadLine()) - 1;
if (a+1 <= matrix.GetLength(0) && b+1 <= matrix.GetLength(1))
{
    int number = 0;
    number = (matrix[a, b]);
    Console.WriteLine($"Найденное число: {number}");
}
else
{
Console.WriteLine("Такого элемента нет");
}


