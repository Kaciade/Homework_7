// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

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

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int k = 0; k < matrix.GetLength(1) - 1; k++)
        {
            if (matrix[i, k] < matrix[i, k + 1])
            {
                int temp = matrix[i, k + 1];
                matrix[i, k + 1] = matrix[i, k];
                matrix[i, k] = temp;
            }
        }
    }
}

Console.WriteLine($"\nИзменённый массив {m} x {n}:");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]}\t");
    }
    Console.WriteLine();
}
Console.WriteLine();