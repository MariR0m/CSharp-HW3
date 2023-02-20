// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double InputNamber(string str)
{
    System.Console.Write(str);
    return Convert.ToInt32(Console.ReadLine());
}

double CalculationX (double b1, double b2, double k1, double k2)
{
double x;
x = (b2-b1)/(k1-k2);
return x;
}

double CalculationY ( double b2, double k2, double x)
{
double y;
y= k2*x+b2;
return y;
}

double b1 = InputNamber("Введите координату b1: ");
double k1 = InputNamber("Введите координату k1: ");
double b2 = InputNamber("Введите координату b2: ");
double k2 = InputNamber("Введите координату k2: ");

double x = CalculationX(b1, b2, k1, k2);
double y = CalculationY( b2, k2, x);

System.Console.WriteLine( x + ", " + y);