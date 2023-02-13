// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// if (B<1)
// {
//   System.Console.WriteLine("Число B не натуральное.");  
// }
// else
// {
// System.Console.WriteLine(Math.Pow(A, B));
// }


int InputNamber(string str)
{
    System.Console.Write(str);
    return Convert.ToInt32(Console.ReadLine());
}

int NumberInDegree(int X, int Y)
{
    int number = X;
    for (int i = 1; i < Y; i++)
    {
        number = number * X;
    }
    return number;
}

int A = InputNamber("Введите число A: ");
int B = InputNamber("Введите число B: ");


if (B < 1)
{
    System.Console.WriteLine("Число B не натуральное.");

}

else System.Console.WriteLine("Результат вовведения в степень: " + NumberInDegree(A, B));

