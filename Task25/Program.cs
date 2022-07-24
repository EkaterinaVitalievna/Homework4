// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
double Num(double a, double b)
{
    double result = Math.Pow(a, b);
    return result;
}

Console.Write("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Первое число в степени второго числа " + Num(n, m));