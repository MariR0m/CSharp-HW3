// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

void SumElements(int[,] matrix)
{
    int Sum;
    int Row = 0;
    int MinSum = Int32.MaxValue;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Sum = Sum + matrix[i, j];

        }
        if (Sum < MinSum)
        {
            Row = i + 1;
            MinSum = Sum;
        }
    }
    System.Console.WriteLine("Строка с минимальной суммой: " + Row);
}

int rows = ReadInt("Введите количество строк матрицы: ");
int cols = ReadInt("Введите количество столбцов матрицы: ");
System.Console.WriteLine();
int[,] MyMatrix = GenerateMatrix(rows, cols);
PrintMatrix(MyMatrix);
System.Console.WriteLine();
SumElements(MyMatrix);


