// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

int[,] PrintDescending(int[,] matrix)
{

  
  
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int max = j;
            for (int r=j+1; r<matrix.GetLength(1); r++)
            {
                if (matrix[i,r]>matrix[i,max])
                {
                    max=r;
                }
            }
            Swap(matrix, i, j, max);
        }
        
    } 
    return matrix;
}

void Swap (int[,] matrix, int i, int j, int max)
{
int temp = matrix [i,j];
matrix [i,j] = matrix [i,max];
matrix [i,max] = temp;
}

int rows = ReadInt("Введите количество строк матрицы: ");
int cols = ReadInt("Введите количество столбцов матрицы: ");
System.Console.WriteLine();
int[,] MyMatrix = GenerateMatrix(rows, cols);
PrintMatrix(MyMatrix);
System.Console.WriteLine();
PrintDescending(MyMatrix);
PrintMatrix(MyMatrix);


