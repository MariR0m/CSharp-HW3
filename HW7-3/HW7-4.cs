// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(0, 11);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void AverageColumn(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double SumColumn = 0;
        double Average;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            SumColumn = SumColumn + matrix[i, j];
        }
        Average = Math.Round(SumColumn / matrix.GetLength(0), 1);
        System.Console.WriteLine("Среднее арифметическое столбца: " + Average);
    }
}

int rows = ReadInt("Введите количество строк матрицы: ");
int cols = ReadInt("Введите количество столбцов матрицы: ");
System.Console.WriteLine();
int[,] MyMatrix = GenerateMatrix(rows, cols);
PrintMatrix(MyMatrix);
AverageColumn(MyMatrix);



