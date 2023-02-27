// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MatrixProduct (int[,] matrix1, int [,] matrix2)
{
    int[,] MatrixProduct = new int[matrix1.GetLength(0),matrix2.GetLength(1)];
    for (int i = 0; i < MatrixProduct.GetLength(0); i++)
    {
        for (int j = 0; j < MatrixProduct.GetLength(1); j++)
        {
            for (int x = 0; x < matrix1.GetLength(1); x++)
            {
               MatrixProduct[i,j] += matrix1[i,x]*matrix2[x,j];
            }
        }

    }
    return MatrixProduct;
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



int rows = ReadInt("Введите количество строк первой матрицы: ");
int cols = ReadInt("Введите количество столбцов первой матрицы: ");
System.Console.WriteLine();
int[,] MyMatrix = GenerateMatrix(rows, cols);
PrintMatrix(MyMatrix);
System.Console.WriteLine();
System.Console.WriteLine("Вторая матрица: ");
System.Console.WriteLine();
int[,] MyMatrix2 = GenerateMatrix(cols, rows);
PrintMatrix(MyMatrix2);
System.Console.WriteLine();
System.Console.WriteLine("Произведение: ");
System.Console.WriteLine();
PrintMatrix(MatrixProduct(MyMatrix, MyMatrix2));
