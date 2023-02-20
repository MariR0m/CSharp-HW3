// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int [] EnterNumbers (int size, int minValue, int maxValue)
// {
//     int [] numbers = new int [size];
//     for (int i = 0; i < size; i++)
//     {
//         System.Console.WriteLine("Введите число от " + minValue + " до " + maxValue);
//        numbers [i] = Convert.ToInt32(Console.ReadLine());
//     }
// return numbers;
// }
// Вариант 1: 

// int[] EnterNumbers(int size, int minValue, int maxValue)
// {
//     int[] numbers = new int[size];
//     int number;
//     for (int i = 0; i < size; i++)
//     {
//         System.Console.WriteLine("Введите число от " + minValue + " до " + maxValue);
//         number = Convert.ToInt32(Console.ReadLine());
//         if (number > minValue && number < maxValue)
//         {
//             numbers[i] = +number;
//         }
//         else System.Console.WriteLine("Вы ввели не число");
//     }
//     return numbers;
// }

// void PrintArray(int[] array)
// {
//     System.Console.WriteLine("[" + string.Join("; ", array) + "]");
// }

// int PositiveNumbers(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// int[] MyArray = EnterNumbers(5, -100, 100);
// PrintArray(MyArray);
// int QuantityPositiveNumbers = PositiveNumbers(MyArray);

// System.Console.WriteLine("Введенных чисел болольше 0 : " + QuantityPositiveNumbers);

int[] EnterNumbers(int size)
{
    int[] numbers = new int[size];
    
     for (int i = 0; i < size; i++)
     {
         System.Console.WriteLine("Введите число: ");
        numbers [i] = Convert.ToInt32(Console.ReadLine());
     }
 return numbers;
 }


void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join("; ", array) + "]");
}

int PositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int[] MyArray = EnterNumbers(5);
PrintArray(MyArray);
int QuantityPositiveNumbers = PositiveNumbers(MyArray);

System.Console.WriteLine("Введенных чисел болольше 0 : " + QuantityPositiveNumbers);