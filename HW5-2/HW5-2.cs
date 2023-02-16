// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// Сделала ограничение числел масива от -10 до 10,
// т.к. иначе числа большие и 

int[] GenerateArray(int size)
{
    int[] array = new int[size];
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(-10, 11);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int SumOdd(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        result += array[i];
    }
    return result;
}

int[] MyArray = GenerateArray(5);
PrintArray(MyArray);
System.Console.WriteLine($"Сумма чисел на нечетных позициях равна {SumOdd(MyArray)}");