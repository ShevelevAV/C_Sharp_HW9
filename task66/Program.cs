/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/
int SumNumbers(int a, int b)
{
    int sum=0;
    if (a==b)
    {
    
        return sum = sum + a;    
    }
    sum=sum+b;
    return (sum = sum + SumNumbers(a,b-1));
}

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumNumbers(N,M));
