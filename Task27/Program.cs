// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число:");
int numbers = Convert.ToInt32(Console.ReadLine());

int SumNum(int num)
{
    int div = 0;
    int sum = 0;
    while (num > 0)
    {
        div = num % 10;//узнаём последнюю цифру числа
        sum = sum + div;//суммируем 0 с последней цифрой числа
        num = num / 10;//делим на 10, чтобы убрать последнюю цифру числа перед повторным вычислением 
    }
    return sum;
}
Console.WriteLine("Сумма цифр в числе: " + SumNum(numbers));