﻿// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
Console.WriteLine("Введите числа M и N");
int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());
if (M < N)
{(M,N) = (N,M);}
int Recursion(int M, int N)
{
    if (M == N) return M;
    else
    return (M +  Recursion(M-1, N));
}   
Console.Write($"{M +  Recursion(M-1, N)}");
Recursion(M, N);
