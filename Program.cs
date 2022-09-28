// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Clear();
Console.Write("Введите число M: ");
int numberM = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN = int.Parse(Console.ReadLine());
void SumNaturalNumbers(int m, int n)
{
    if ((m <= 0) || (n <= 0))
    {
        Console.WriteLine("Ошибка: Одно из чисел меньше нуля");
        Console.Write("Введите число M: ");
        int numberM2 = int.Parse(Console.ReadLine());
        Console.Write("Введите число N: ");
        int numberN2 = int.Parse(Console.ReadLine());
        SumNaturalNumbers(numberM2, numberN2);
    }
    else
    {
        int sum = 0;
        while (m <= n)
        {
            sum += m;
            m++;
        }
        Console.WriteLine(sum);
    }
}
SumNaturalNumbers(numberM,numberN);