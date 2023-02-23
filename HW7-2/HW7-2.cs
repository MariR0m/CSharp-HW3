// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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

void RearchNumber(int[,] matrix, int rows, int cols, int row, int col)
{
    int RearchNum;
    if (row <= rows && col <= cols)
    {
        RearchNum = matrix[row - 1, col - 1];
        System.Console.WriteLine("Введенный элемент:" + RearchNum);
    }
    else System.Console.WriteLine("Такого элемента нет");
}

int rows = ReadInt("Введите количество строк матрицы: ");
int cols = ReadInt("Введите количество столбцов матрицы: ");
System.Console.WriteLine();
int[,] MyMatrix = GenerateMatrix(rows, cols);
PrintMatrix(MyMatrix);
System.Console.WriteLine();
int row = ReadInt("Введите искомый номер строки: ");
int col = ReadInt("Введите искомый номер столбца: ");

RearchNumber(MyMatrix, rows, cols, row, col);