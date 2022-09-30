// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int SumNumbersInNumber(int n)
{
    int oldn = n;
    int sum = 0;
    while (n > 0)
    {
        int g = n % 10;
        n = n / 10;
        sum = sum + g;
    }
    Console.WriteLine($"{oldn} - > {sum}");
    return sum;
}
SumNumbersInNumber(number);