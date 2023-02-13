// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// Вы просили массив из 12 чисел и числа в диапозоне от 0 до 100

int[] FillArray(int size)
{
    int[] Arr = new int[size];
    for (int i = 0; i < Arr.Length; i++)
    {
        Arr[i] = new Random().Next(0, 101);
    }
    return Arr;
}

void PrintArr(int[] array)
{
    int count = array.Length;
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int[] MyArray = FillArray(12);
PrintArr(MyArray);