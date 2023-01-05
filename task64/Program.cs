/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

string Numbers(int a, int b)
{
    if (a==b)
    {
        return a.ToString();
    }
    return (a+" "+Numbers(a-1,b));
}

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
int M = 1;
Console.WriteLine(Numbers(N,M));
