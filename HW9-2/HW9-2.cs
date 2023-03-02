// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Output(int M, int N)
{
    if (M == 0)
        return (N + 1);

    else if (M > 0 && N == 0)
        return Output((M - 1), 1);

    else if (M > 0 && N > 0)
        return Output((M - 1), Output(M, (N - 1)));

    return 0;
}

M:
int M = ReadInt("Введите число M:");
N:
int N = ReadInt("Введите число N:");

if (M < 0)
{
    System.Console.WriteLine("Введено число M меньше 0, введите верное число");
    goto M;
}
else if (N < 0)
{
    System.Console.WriteLine("Введено число N меньше 0, введите верное число");
    goto N;
}

System.Console.WriteLine();

System.Console.WriteLine(Output(M, N));
