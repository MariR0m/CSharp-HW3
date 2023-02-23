//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] GenerateMatrix(int rows, int cols)
{
    double[,] matrix = new double[rows, cols];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(rand.Next(-10, 11) + rand.NextDouble(), 1);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
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

int rows = ReadInt("Введите количество строк матрицы: ");
int cols = ReadInt("Введите количество столбцов матрицы: ");
System.Console.WriteLine();
double[,] MyMatrix = GenerateMatrix(rows, cols);
PrintMatrix(MyMatrix);