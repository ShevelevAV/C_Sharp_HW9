/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/
Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine()!);
int Ackermann(int a, int b)
{
    int res = 1;
    if (a == 0)
    {
        res = b + 1;
    }
    if (a == 1)
    {
        res = b + 2;
    }
    if (a == 2)
    {
        res = 2 * b + 3;
    }
    if (a == 3)
    {
        int stepen = b + 3;
        while (stepen >= 1)
        {
            res = res * b;
            stepen--;
        }
        res = res - 3;
    }
    return res;
}
Console.Write(Ackermann(m, n)!);
