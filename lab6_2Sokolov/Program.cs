using ClassLibrary1;
double[,] matrix = new double[6, 4];
double[] maxElements = new double[6];

for (int i = 0; i < 6; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write($"Введите элемент [{i}, {j}]: ");
        matrix[i, j] = double.Parse(Console.ReadLine()!);
    }
}

for (int i = 0; i < 6; i++)
{
    double max = matrix[i, 0];
    for (int j = 1; j < 4; j++)
    {
        if (matrix[i, j] > max)
        {
            max = matrix[i, j];
        }
    }
    maxElements[i] = max;
}

Console.WriteLine("максимальные элементы строк матрицы");
for (int i = 0; i < 6; i++)
{
    Console.Write(maxElements[i] + " ");
}