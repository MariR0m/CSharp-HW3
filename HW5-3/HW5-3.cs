// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double[] GenerateArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rand.Next(minValue, maxValue) + rand.NextDouble(), 3);
    }
    return array;
}

void PrintArray(double[] array)
{
    System.Console.WriteLine("[" + string.Join("; ", array) + "]");
}

double MaxNunber(double[] array)
{
    double resultMax = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > resultMax)
        {
            resultMax = array[i];
        }
    }
    return resultMax;
}

double MinNunber(double[] array)
{
    double resultMin = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < resultMin)
        {
            resultMin = array[i];
        }
    }
    return resultMin;
}

double DifNumbers(double Max, double Min)
{
    double result = Math.Round((Max - Min), 3);
    return result;
}

double[] MyArray = GenerateArray(12, 0, 101);
PrintArray(MyArray);
double Num1 = MaxNunber(MyArray);
double Num2 = MinNunber(MyArray);
double DifNum = DifNumbers(Num1, Num2);

System.Console.WriteLine("Разница между наибольшим и наименьшим числом равна: " + DifNum);


