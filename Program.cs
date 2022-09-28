// Задача 64: Задайте значение N. Напишите программу, которая выведет все чётные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "4, 2"  // N = 8 -> "8, 6, 4, 2"
Console.Clear();
Console.Write("Введите число N: ");
int number = int.Parse(Console.ReadLine());
int i = 1;
Console.Write($"N = {number} -> '");
void EvenNumbers(int N)
{
    while (i <= number)
    {
        if (i % 2 == 0)
        { 
            Console.Write($" {i} ");
            i++;
            EvenNumbers(number);
        }
        else 
        {
            i++;
            EvenNumbers(number);
        }
    }
}
EvenNumbers(number);
Console.Write("'");
