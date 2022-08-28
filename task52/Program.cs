/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 4
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 4,6; 4. */
const int M = 4;
const int N = 4;
double[,] matrix = new double [M, N];
Random rand = new Random();
for (int i = 0; i < M; i++)
{
    for (int j = 0; j < N; j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        Console.Write($"{matrix[i, j] + " "}");
    }
    Console.WriteLine();
}
double a = Math.Round(((matrix[0,0] + matrix[0,1] + matrix[0,2] + matrix[0,3]) / 4), 2);
double b = Math.Round(((matrix[1,0] + matrix[1,1] + matrix[1,2] + matrix[1,3]) / 4), 2);
double c = Math.Round(((matrix[2,0] + matrix[2,1] + matrix[2,2] + matrix[2,3]) / 4), 2);
double d = Math.Round(((matrix[2,0] + matrix[2,1] + matrix[2,2] + matrix[3,3]) / 4), 2);
Console.Write($"{a}, {b}, {c}, {d}");
