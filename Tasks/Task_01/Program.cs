// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

Console.Write("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите левую часть массива: ");
int min = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите правую часть массива: ");
int max = int.Parse(Console.ReadLine() ?? "0");
int [,] matrix = new int [m, n];
Random random = new Random();

Console.WriteLine($"\nВаш массив {m} x {n}:");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = random.Next(min, max);
        Console.Write($"{matrix[i, j]}\t");
    }
    Console.WriteLine();
}

Console.WriteLine();
for (int i = 0; i < matrix.GetLength(1); i++)
{
    int sum = 0;
    int average = 0;
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        sum = sum + matrix[j, i];
    }
    average = sum / m;
    Console.WriteLine($"Среднее арифметическое {i+1} столбца = {average}");
}
Console.WriteLine();