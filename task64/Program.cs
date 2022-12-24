//  Задача 64. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
int N2 = 1;

int Recursion(int N, int N2)
{
    if (N == N2)
    return N2;
    else
        Console.Write($"{Recursion(N, N2 + 1)}, ");
    return N2;
}    
Recursion(N, N2-1);
