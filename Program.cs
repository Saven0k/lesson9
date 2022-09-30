﻿// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8
Console.Clear();
Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine());
int DegreeNumber(int A, int B)
{
    if (B == 0)
    {
        return 1;
    }
    else
    {
        return A * DegreeNumber(A, B - 1);
    }
}
Console.WriteLine(DegreeNumber(a, b));