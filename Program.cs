// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


// Первый вариант решения по формуле 
// (m,n,0)=m+n
// (m,n,1)=m*n
// (m,n,2)=m^{n}

// Console.Clear();
// Console.Write("Введите число M: ");
// int numberM = int.Parse(Console.ReadLine());
// Console.Write("Введите число N: ");
// int numberN = int.Parse(Console.ReadLine());
// Console.Write("Введите число x: ");
// int numberx = int.Parse(Console.ReadLine());
// void AckermannFunction(int m, int n, int x)
// {
//     int result = 0;
//     if ((m < 0) || (n < 0))
//     {
//         Console.WriteLine("Ошибка: Одно из чисел меньше нуля");
//         Console.Write("Введите число M: ");
//         int numberM2 = int.Parse(Console.ReadLine());
//         Console.Write("Введите число N: ");
//         int numberN2 = int.Parse(Console.ReadLine());
//         Console.Write("Введите число x: ");
//         int numberx2 = int.Parse(Console.ReadLine());
//         AckermannFunction(numberM2, numberN2, x);
//     }
//     else
//     {
//         if (x == 0) result = m + n;
//         else if (x == 1) result = m*n;
//         else if (x == 2) result = Convert.ToInt32(Math.Pow(m , n));
//     }
//     Console.WriteLine($" m = {m}, n = {n} -> F(m,n,{x}) = {result}");
// }
// AckermannFunction(numberM, numberN, numberx);

Console.Clear();
Console.Write("Введите число M: ");
int numberM = Math.Abs(int.Parse(Console.ReadLine()));
Console.Write("Введите число N: ");
int numberN = Math.Abs(int.Parse(Console.ReadLine()));
int AckermannFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return AckermannFunction(m - 1, 1);
    else return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}
int res = AckermannFunction(numberM, numberN);
Console.WriteLine(res);
