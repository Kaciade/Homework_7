// В прямоугольной матрице найти строку с наименьшей суммой элементов.

Console.WriteLine();
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

int [] sum = new int [n];
Console.WriteLine();
for (int i = 0; i < m; i++)
{
    int result = 0;
    for (int j = 0; j < n; j++)
    {
        result = result + matrix[i, j];
    }
    sum[i] = result;
}

int minsum = sum[0];
for (int i = 0; i < m; i++)
{
    if (sum[i] < minsum)
    {
        minsum = sum[i];
    }
}

for (int i = 0; i < m; i++)
{
    if (sum[i] == minsum)
    {
        Console.WriteLine($"Строка с наименьшей суммой элементов -> {i+1}\nСумма элементов {i+1} строки = {minsum}");
    }
}

Console.WriteLine();