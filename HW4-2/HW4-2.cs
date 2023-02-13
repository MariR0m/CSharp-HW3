// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

string? InputNumber(string text)
{
    System.Console.WriteLine(text);
    return Console.ReadLine();
}

int SumNamber(string text)
{

    int result = 0;
    for (int i = 0; i < text.Length; i++)
    {
        result = result + ((int)char.GetNumericValue(text[i]));
    }
    return result;

}


string? A = InputNumber("Введите число N:");

if (int.TryParse(A, out int number))
{
    System.Console.WriteLine("Сумма цифр в веденном числе равна: " + SumNamber(A));
}

else System.Console.WriteLine("Введено не число!");
