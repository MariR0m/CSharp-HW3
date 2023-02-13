// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

string? InputNumber(string text)
{
    System.Console.WriteLine(text);
    return Console.ReadLine();
}

string A = InputNumber("Введите число N:");

if (int.TryParse(A, out int number))
{
    int result = 0;
    for (int i = 0; i < A.Length; i++)
    {
        result = result + ((int)char.GetNumericValue(A[i]));
    }
    System.Console.WriteLine("Сумма цифр в веденном числе равна: " + result);
}

else System.Console.WriteLine("Введено не число!");